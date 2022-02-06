namespace EDCalculations.APIs.EDSM.Models;

public class SystemBodies
{
    public int id { get; set; }
    public string name { get; set; }
    public SystemBody[] bodies { get; set; }
}

public class SystemBody
{
    public int id { get; set; }
    public string name { get; set; }
    public string type { get; set; }
    public string subType { get; set; }
    // At this time, ring data is not needed beyond knowing that they exist, thus no specific type beyond object.
    public object[]? rings { get; set; }
}
