namespace EDCalculations.APIs.EDSM.Models;

public class SystemFactionInfo
{
    public int Id { get; set; }
    public int Id64 { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public ControllingFaction ControllingFaction { get; set; } = new();
    public Faction[] Factions { get; set; } = new Faction[1];
}

public class ControllingFaction
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Allegiance { get; set; } = string.Empty;
    public string Government { get; set; } = string.Empty;
}

public class Faction
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Allegiance { get; set; } = string.Empty;
    public string Government { get; set; } = string.Empty;
    public int Influence { get; set; }
    public string State { get; set; } = string.Empty;
    public object[] ActiveStates { get; set; } = new object[1];
    public object[] RecoveringStates { get; set; } = new object[1];
    public object[] PendingStates { get; set; } = new object[1];
    public string Happiness { get; set; } = string.Empty;
    public bool IsPlayer { get; set; }
    public int LastUpdate { get; set; }
}
