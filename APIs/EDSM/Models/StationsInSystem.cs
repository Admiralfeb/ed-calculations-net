namespace EDCalculations.APIs.EDSM.Models;

public class SystemStations
{
    public int id { get; set; }
    public int id64 { get; set; }
    public string url { get; set; }
    public string name { get; set; }
    public Station[] stations { get; set; }
}

public class Station
{
    public int id { get; set; }
    public int markedId { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public StationBody? body { get; set; }
    public double distanceToArrival { get; set; }
    public string allegiance { get; set; }
    public string government { get; set; }
    public string economy { get; set; }
    public string secondEconomy { get; set; }
    public bool haveMarket { get; set; }
    public bool haveShipyard { get; set; }
    public bool haveOutfitting { get; set; }
    public string[] otherServices { get; set; }
    public StationControllingFaction? controllingFaction { get; set; }
    public StationUpdateTime updateTime;
}

public class StationBody
{
    public int id { get; set; }
    public string name { get; set; }
    public double? latitude { get; set; }
    public double? longitude { get; set; }
}

public class StationControllingFaction
{
    public int id { get; set; }
    public string name { get; set; }
}

public class StationUpdateTime
{
    public string information { get; set; }
    public string market { get; set; }
    public string shipyard { get; set; }
    public string outfitting { get; set; }
}
