namespace EDCalculations.EDSM.Models;

public class Possibility
{
    public string SystemName { get; set; }
    public int Distance { get; set; }
    public IEnumerable<string> MissionSystems { get; set; }

    public Possibility(string systemName, int distance, IEnumerable<string> missionSystems)
    {
        this.SystemName = systemName;
        this.Distance = distance;
        this.MissionSystems = missionSystems;
    }
    public Possibility(SphereSystem system, IEnumerable<SphereSystem> closeSystems)
    {
        this.SystemName = system.name;
        this.Distance = system.distance;
        this.MissionSystems = closeSystems.Select(x => x.name);
    }
}
