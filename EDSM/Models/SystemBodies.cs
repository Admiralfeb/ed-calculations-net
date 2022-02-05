namespace EDCalculations.EDSM.Models;

public class SystemBodies
{
    public int id;
    public string name;
    public SystemBody[] bodies;
}

public class SystemBody
{
    public int id;
    public string name;
    public string type;
    public string subType;
    public object[]? rings;
}
