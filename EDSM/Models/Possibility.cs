namespace EDCalculations.EDSM.Models;

[Serializable]
public class Possibility
{
    public string SystemName;
    public int Distance;
    public IEnumerable<string> MissionSystems;

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
