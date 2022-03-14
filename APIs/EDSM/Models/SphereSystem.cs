namespace UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM.Models;

public class SphereSystem
{
    public float Distance { get; set; }
    public int BodyCount { get; set; }
    public string Name { get; set; } = string.Empty;
    public Coordinants Coords { get; set; } = new();
    public bool CoordsLocked { get; set; }
    public SysInfo Information { get; set; } = new();
    public PrimaryStar PrimaryStar { get; set; } = new();
}

public class Coordinants
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
}

public class SysInfo
{
    public string? Allegiance { get; set; }
    public string? Government { get; set; }
    public string? Faction { get; set; }
    public string? FactionState { get; set; }
    public int Population { get; set; }
    public string? Security { get; set; }
    public string? Economy { get; set; }
    public string? SecondEconomy { get; set; }
    public string? Reserve { get; set; }
}

public class PrimaryStar
{
    public string Type { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsScoopable { get; set; }
}