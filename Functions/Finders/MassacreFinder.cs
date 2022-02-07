using System.Text.Json;

using EDCalculations.APIs.EDSM;
using EDCalculations.APIs.EDSM.Models;
using EDCalculations.Functions.Models;

namespace EDCalculations.Functions.Finders;

public class MassacreFinder
{
    private readonly EdsmQueries edsm;
    public MassacreFinder(HttpClient client)
    {
        edsm = new EdsmQueries(client);
    }

    public async Task<string> FindMassacreSystemPossibilitiesAsync(string systemName, int range, IProgress<string>? progress, CancellationToken? cancelToken)
    {
        progress?.Report("Retrieving Systems");
        var systemList = await edsm.GetSystemsinSphereAsync(systemName, range);
        systemList = systemList.Where(x => x.information != null);

        progress?.Report($"Retrieving Body Information for {systemList.Count()} systems");
        systemList = await GetSystemsWithRingsAsync(systemList);

        progress?.Report($"Retrieving Faction Information for {systemList.Count()} systems");
        systemList = await GetSystemsWithAnarchyFactionAsync(systemList);

        var possibilities = await FinalizePossibilitiesAsync(systemList, progress);
        progress?.Report($"Process complete: {possibilities.Count()} possible massacre systems.");

        return JsonSerializer.Serialize(possibilities);
    }

    private async Task<IEnumerable<SphereSystem>> GetSystemsWithRingsAsync(IEnumerable<SphereSystem> systemList)
    {
        IEnumerable<SphereSystem> hasRingsList = new List<SphereSystem>();
        foreach (var system in systemList)
        {
            var systemBodies = (await edsm.GetBodiesInSystemAsync(system.name)).bodies;

            if (systemBodies.Any(x => x.rings != null))
                hasRingsList = hasRingsList.Append(system);
        }
        return hasRingsList;
    }

    private async Task<IEnumerable<SphereSystem>> GetSystemsWithAnarchyFactionAsync(IEnumerable<SphereSystem> systemList)
    {
        IEnumerable<SphereSystem> hasAnarchyList = new List<SphereSystem>();
        foreach (var system in systemList)
        {
            var systemFactionInfo = await edsm.GetFactionsInSystemAsync(system.name);
            if (systemFactionInfo.factions?.Count(x => x.government.ToUpper() == "ANARCHY") > 0)
                hasAnarchyList = hasAnarchyList.Append(system);
        }
        return hasAnarchyList;
    }

    private async Task<IEnumerable<MassacrePossibility>> FinalizePossibilitiesAsync(IEnumerable<SphereSystem> systemList, IProgress<string>? progress)
    {
        IEnumerable<MassacrePossibility> possibilities = new List<MassacrePossibility>();
        foreach (var (system, i) in systemList.Select((value, i) => (value, i)))
        {
            progress?.Report($"Checking for populated systems. {i} of {systemList.Count()}. System: {system.name}");
            var closeSystems = await GetPopulatedSystemsWithin10LYAsync(system);
            if (closeSystems.Any())
            {
                MassacrePossibility possibility = new(system, closeSystems);
                possibilities = possibilities.Append(possibility);
            }
        }
        return possibilities;
    }

    private async Task<IEnumerable<SphereSystem>> GetPopulatedSystemsWithin10LYAsync(SphereSystem system)
    {
        var closeSystems = await edsm.GetSystemsinSphereAsync(system.name, 10);
        return closeSystems.Where(x => x.information?.population > 100);
    }
}
