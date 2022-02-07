namespace EDCalculations.APIs.EDSM.Models;

public class SystemFactionInfo
{
    public int id { get; set; }
    public int id64 { get; set; }
    public string name { get; set; } = string.Empty;
    public string url { get; set; } = string.Empty;
    public ControllingFaction controllingFaction { get; set; } = new();
    public Faction[] factions { get; set; } = new Faction[1];
}

public class ControllingFaction
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string allegiance { get; set; } = string.Empty;
    public string government { get; set; } = string.Empty;
}

public class Faction
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string allegiance { get; set; } = string.Empty;
    public string government { get; set; } = string.Empty;
    public int influence { get; set; }
    public string state { get; set; } = string.Empty;
    public object[] activeStates { get; set; } = new object[1];
    public object[] recoveringStates { get; set; } = new object[1];
    public object[] pendingStates { get; set; } = new object[1];
    public string happiness { get; set; } = string.Empty;
    public bool isPlayer { get; set; }
    public int lastUpdate { get; set; }
}
