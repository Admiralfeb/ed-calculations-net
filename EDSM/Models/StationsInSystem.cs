namespace EDCalculations.EDSM.Models;

public class SystemStations
{
    public int id;
    public int id64;
    public string url;
    public string name;
    public Station[] stations;
}

public class Station
{
    public int id;
    public int markedId;
    public string type;
    public string name;
    public StationBody? body;
    public double distanceToArrival;
    public string allegiance;
    public string government;
    public string economy;
    public string secondEconomy;
    public bool haveMarket;
    public bool haveShipyard;
    public bool haveOutfitting;
    public string[] otherServices;
    public StationControllingFaction? controllingFaction;
    public StationUpdateTime updateTime;
}

public class StationBody
{
    public int id;
    public string name;
    public double? latitude;
    public double? longitude;
}

public class StationControllingFaction
{
    public int id;
    public string name;
}

public class StationUpdateTime
{
    public string information;
    public string market;
    public string shipyard;
    public string outfitting;
}
