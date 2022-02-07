namespace EDCalculations.APIs.EDSM.Models;

public class SystemBodies
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public SystemBody[] bodies { get; set; } = new SystemBody[1];
}

public class SystemBody
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string type { get; set; } = string.Empty;
    public string subType { get; set; } = string.Empty;
    // At this time, ring data is not needed beyond knowing that they exist, thus no specific type beyond object.
    public object[]? rings { get; set; }
}
