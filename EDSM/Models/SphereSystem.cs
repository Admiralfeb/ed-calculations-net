namespace EDCalculations.EDSM.Models;

public class SphereSystem
{
    public int distance;
    public int bodyCount;
    public string name;
    public Coordinants coords;
    public bool coordsLocked;
    public SysInfo information;
    public PrimaryStar primaryStar;
}

public class Coordinants
{
    public float x;
    public float y;
    public float z;
}


public class SysInfo
{
    public string? allegiance;
    public string? government;
    public string? faction;
    public string? factionState;
    public int population;
    public string? security;
    public string? economy;
    public string? secondEconomy;
    public string? reserve;
}

public class PrimaryStar
{
    public string type;
    public string name;
    public bool isScoopable;
}
