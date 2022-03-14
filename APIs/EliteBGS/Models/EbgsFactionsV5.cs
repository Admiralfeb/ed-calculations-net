namespace UnitedSystemsCooperative.Utils.EDCalc.APIs.EliteBGS.Models;

public class EbgsFactionsV5
{
    public int Eddb_id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Name_lower { get; set; } = string.Empty;
    public string Updated_at { get; set; } = string.Empty;
    public string Government { get; set; } = string.Empty;
    public string Allegiance { get; set; } = string.Empty;
    public string Home_system_name { get; set; } = string.Empty;
    public string Is_player_faction { get; set; } = string.Empty;
    public IEnumerable<EbgsFactionPresenceV5> Faction_presence { get; set; } = new List<EbgsFactionPresenceV5>();
    public IEnumerable<object> History { get; set; } = new List<object>();
}

public class EbgsFactionPresenceV5
{
    public string System_name { get; set; } = string.Empty;
    public string System_name_lower { get; set; } = string.Empty;
    public string System_id { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public float Influence { get; set; }
    public string Happiness { get; set; } = string.Empty;
    public IEnumerable<object> Active_states { get; set; } = new List<object>();
    public IEnumerable<object> Pending_states { get; set; } = new List<object>();
    public IEnumerable<object> Recovering_states { get; set; } = new List<object>();
    public IEnumerable<object> Conflicts { get; set; } = new List<object>();
    public object System_details { get; set; } = new();
    public string Updated_at { get; set; } = string.Empty;
}

public class EbgsStateActiveV5
{
    public string State { get; set; } = string.Empty;
}

public class EbgsStateV5
{
    public string State { get; set; } = string.Empty;
    public int Trend { get; set; }
}