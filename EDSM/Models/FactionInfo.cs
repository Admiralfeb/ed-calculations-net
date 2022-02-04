namespace EDCalculations.EDSM.Models;

public class SystemFactionInfo
{
    int id;
    int id64;
    string name;
    string url;
    ControllingFaction controllingFaction;
    Faction[] factions;
}

public class ControllingFaction
{
    int id;
    string name;
    string allegiance;
    string government;
}

public class Faction
{
    int id;
    string name;
    string allegiance;
    string government;
    int influence;
    string state;
    object[] activeStates;
    object[] recoveringStates;
    object[] pendingStates;
    string happiness;
    bool isPlayer;
    int lastUpdate;
}
