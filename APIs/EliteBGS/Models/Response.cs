namespace EDCalculations.APIs.EliteBgs.Models;

public class Response<T>
{
    public IEnumerable<T> docs { get; set; } = new List<T>();
    public int total { get; set; }
    public int limit { get; set; }
    public int page { get; set; }
    public int pages { get; set; }
    public int pagingCounter { get; set; }
    public bool hasPrevPage { get; set; }
    public bool hasNextPage { get; set; }
    public object prevPage { get; set; } = new();
    public object nextPage { get; set; } = new();
}
