using UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM.Models;

namespace UnitedSystemsCooperative.Utils.EDCalc.Functions.Models;

public class MassacrePossibility
{
    public string SystemName { get; set; }
    public float Distance { get; set; }
    public IEnumerable<string> MissionSystems { get; set; }

    public MassacrePossibility(SphereSystem system, IEnumerable<SphereSystem> closeSystems)
    {
        this.SystemName = system.Name;
        this.Distance = system.Distance;
        this.MissionSystems = closeSystems.Select(x => x.Name);
    }
}