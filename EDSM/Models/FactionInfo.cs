namespace EDCalculations.EDSM.Models;

public class SystemFactionInfo
{
    public int id;
    public int id64;
    public string name;
    public string url;
    public ControllingFaction controllingFaction;
    public Faction[] factions;
}

public class ControllingFaction
{
    public int id;
    public string name;
    public string allegiance;
    public string government;
}

public class Faction
{
    public int id;
    public string name;
    public string allegiance;
    public string government;
    public int influence;
    public string state;
    public object[] activeStates;
    public object[] recoveringStates;
    public object[] pendingStates;
    public string happiness;
    public bool isPlayer;
    public int lastUpdate;
}
