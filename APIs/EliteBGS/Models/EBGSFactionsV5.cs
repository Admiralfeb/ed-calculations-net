namespace EDCalculations.APIs.EliteBgs.Models;

public class EBGSFactionsV5
{
    public string _id { get; set; }
    public int __v { get; set; }
    public int eddb_id { get; set; }
    public string name { get; set; }
    public string name_lower { get; set; }
    public string updated_at { get; set; }
    public string government { get; set; }
    public string allegiance { get; set; }
    public string home_system_name { get; set; }
    public string is_player_faction { get; set; }
    public IEnumerable<EBGSFactionPresenceV5> faction_presence { get; set; }
    public IEnumerable<object> history { get; set; }
}

public class EBGSFactionPresenceV5
{
    public string system_name { get; set; }
    public string system_name_lower { get; set; }
    public string system_id { get; set; }
    public string state { get; set; }
    public float influence { get; set; }
    public string happiness { get; set; }
    public IEnumerable<object> active_states { get; set; }
    public IEnumerable<object> pending_states { get; set; }
    public IEnumerable<object> recovering_states { get; set; }
    public IEnumerable<object> conflicts { get; set; }
    public object system_details { get; set; }
    public string updated_at { get; set; }
}

public class EBGSStateActiveV5
{
    public string state { get; set; }
}
public class EBGSStateV5
{
    public string state { get; set; }
    public int trend { get; set; }
}
