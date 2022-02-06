namespace EDCalculations.EDSM.Models;

public class SystemFactionInfo
{
    public int id { get; set; }
    public int id64 { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public ControllingFaction controllingFaction { get; set; }
    public Faction[] factions { get; set; }
}

public class ControllingFaction
{
    public int id { get; set; }
    public string name { get; set; }
    public string allegiance { get; set; }
    public string government { get; set; }
}

public class Faction
{
    public int id { get; set; }
    public string name { get; set; }
    public string allegiance { get; set; }
    public string government { get; set; }
    public int influence { get; set; }
    public string state { get; set; }
    public object[] activeStates { get; set; }
    public object[] recoveringStates { get; set; }
    public object[] pendingStates { get; set; }
    public string happiness { get; set; }
    public bool isPlayer { get; set; }
    public int lastUpdate { get; set; }
}
