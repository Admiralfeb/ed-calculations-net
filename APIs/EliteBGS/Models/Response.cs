namespace UnitedSystemsCooperative.Utils.EDCalc.APIs.EliteBGS.Models;

public class Response<T>
{
    public IEnumerable<T> Docs { get; set; } = new List<T>();
    public int Total { get; set; }
    public int Limit { get; set; }
    public int Page { get; set; }
    public int Pages { get; set; }
    public int PagingCounter { get; set; }
    public bool HasPrevPage { get; set; }
    public bool HasNextPage { get; set; }
    public object PrevPage { get; set; } = new();
    public object NextPage { get; set; } = new();
}