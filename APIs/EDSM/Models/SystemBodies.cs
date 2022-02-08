namespace EDCalculations.APIs.EDSM.Models;

public class SystemBodies
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public SystemBody[] Bodies { get; set; } = new SystemBody[1];
}

public class SystemBody
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string SubType { get; set; } = string.Empty;
    // At this time, ring data is not needed beyond knowing that they exist, thus no specific type beyond object.
    public object[]? Rings { get; set; }
}
