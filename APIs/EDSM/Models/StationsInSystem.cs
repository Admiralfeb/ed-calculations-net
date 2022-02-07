namespace EDCalculations.APIs.EDSM.Models;

public class SystemStations
{
    public int id { get; set; }
    public int id64 { get; set; }
    public string url { get; set; } = string.Empty;
    public string name { get; set; } = string.Empty;
    public Station[] stations { get; set; } = new Station[1];
}

public class Station
{
    public int id { get; set; }
    public int markedId { get; set; }
    public string type { get; set; } = string.Empty;
    public string name { get; set; } = string.Empty;
    public StationBody? body { get; set; }
    public double distanceToArrival { get; set; }
    public string allegiance { get; set; } = string.Empty;
    public string government { get; set; } = string.Empty;
    public string economy { get; set; } = string.Empty;
    public string secondEconomy { get; set; } = string.Empty;
    public bool haveMarket { get; set; }
    public bool haveShipyard { get; set; }
    public bool haveOutfitting { get; set; }
    public string[] otherServices { get; set; } = new string[1];
    public StationControllingFaction? controllingFaction { get; set; }
    public StationUpdateTime updateTime { get; set; } = new();
}

public class StationBody
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public double? latitude { get; set; }
    public double? longitude { get; set; }
}

public class StationControllingFaction
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
}

public class StationUpdateTime
{
    public string information { get; set; } = string.Empty;
    public string market { get; set; } = string.Empty;
    public string shipyard { get; set; } = string.Empty;
    public string outfitting { get; set; } = string.Empty;
}
