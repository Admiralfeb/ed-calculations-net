namespace EDCalculations.EDSM.Models;

public class SystemStations
{
    int id;
    int id64;
    string url;
    string name;
    Station[] stations;
}

public class Station
{
    int id;
    int markedId;
    string type;
    string name;
    StationBody? body;
    double distanceToArrival;
    string allegiance;
    string government;
    string economy;
    string secondEconomy;
    bool haveMarket;
    bool haveShipyard;
    bool haveOutfitting;
    string[] otherServices;
    StationControllingFaction? controllingFaction;
    StationUpdateTime updateTime;
}

public class StationBody
{
    int id;
    string name;
    double? latitude;
    double? longitude;
}

public class StationControllingFaction
{
    int id;
    string name;
}

public class StationUpdateTime
{
    string information;
    string market;
    string shipyard;
    string outfitting;
}
