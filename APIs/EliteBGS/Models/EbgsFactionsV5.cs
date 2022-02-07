namespace EDCalculations.APIs.EliteBgs.Models;

public class EbgsFactionsV5
{
    public string _id { get; set; } = string.Empty;
    public int __v { get; set; }
    public int eddb_id { get; set; }
    public string name { get; set; } = string.Empty;
    public string name_lower { get; set; } = string.Empty;
    public string updated_at { get; set; } = string.Empty;
    public string government { get; set; } = string.Empty;
    public string allegiance { get; set; } = string.Empty;
    public string home_system_name { get; set; } = string.Empty;
    public string is_player_faction { get; set; } = string.Empty;
    public IEnumerable<EbgsFactionPresenceV5> faction_presence { get; set; } = new List<EbgsFactionPresenceV5>();
    public IEnumerable<object> history { get; set; } = new List<object>();
}

public class EbgsFactionPresenceV5
{
    public string system_name { get; set; } = string.Empty;
    public string system_name_lower { get; set; } = string.Empty;
    public string system_id { get; set; } = string.Empty;
    public string state { get; set; } = string.Empty;
    public float influence { get; set; }
    public string happiness { get; set; } = string.Empty;
    public IEnumerable<object> active_states { get; set; } = new List<object>();
    public IEnumerable<object> pending_states { get; set; } = new List<object>();
    public IEnumerable<object> recovering_states { get; set; } = new List<object>();
    public IEnumerable<object> conflicts { get; set; } = new List<object>();
    public object system_details { get; set; } = new();
    public string updated_at { get; set; } = string.Empty;
}

public class EbgsStateActiveV5
{
    public string state { get; set; } = string.Empty;
}
public class EbgsStateV5
{
    public string state { get; set; } = string.Empty;
    public int trend { get; set; }
}
