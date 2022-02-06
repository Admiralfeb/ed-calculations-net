using EDCalculations.APIs.EDSM.Models;

namespace EDCalculations.Functions.Models;

public class MassacrePossibility
{
    public string SystemName { get; set; }
    public int Distance { get; set; }
    public IEnumerable<string> MissionSystems { get; set; }

    public MassacrePossibility(string systemName, int distance, IEnumerable<string> missionSystems)
    {
        this.SystemName = systemName;
        this.Distance = distance;
        this.MissionSystems = missionSystems;
    }
    public MassacrePossibility(SphereSystem system, IEnumerable<SphereSystem> closeSystems)
    {
        this.SystemName = system.name;
        this.Distance = system.distance;
        this.MissionSystems = closeSystems.Select(x => x.name);
    }
}
