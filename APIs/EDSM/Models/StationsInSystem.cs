namespace EDCalculations.APIs.EDSM.Models;

public class SystemStations
{
    public int Id { get; set; }
    public int Id64 { get; set; }
    public string Url { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public Station[] Stations { get; set; } = new Station[1];
}

public class Station
{
    public int Id { get; set; }
    public int MarkedId { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public StationBody? Body { get; set; }
    public double DistanceToArrival { get; set; }
    public string Allegiance { get; set; } = string.Empty;
    public string Government { get; set; } = string.Empty;
    public string Economy { get; set; } = string.Empty;
    public string SecondEconomy { get; set; } = string.Empty;
    public bool HaveMarket { get; set; }
    public bool HaveShipyard { get; set; }
    public bool HaveOutfitting { get; set; }
    public string[] OtherServices { get; set; } = new string[1];
    public StationControllingFaction? ControllingFaction { get; set; }
    public StationUpdateTime UpdateTime { get; set; } = new();
}

public class StationBody
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}

public class StationControllingFaction
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class StationUpdateTime
{
    public string Information { get; set; } = string.Empty;
    public string Market { get; set; } = string.Empty;
    public string Shipyard { get; set; } = string.Empty;
    public string Outfitting { get; set; } = string.Empty;
}
