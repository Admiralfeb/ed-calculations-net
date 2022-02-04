namespace EDCalculations.EDSM.Models;

public class SystemBodies
{
    int id;
    string name;
    SystemBody[] bodies;
}

public class SystemBody
{
    int id;
    string name;
    string type;
    string subType;
    object[]? rings;
}
