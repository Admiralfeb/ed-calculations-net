using EDCalculations.APIs.EDSM;

namespace EDCalculations.Functions.Finders;

public class ExpansionFinder
{
    private EdsmQueries edsm;

    public ExpansionFinder(HttpClient client)
    {
        edsm = new EdsmQueries(client);
    }

    public void FindExpansionByFaction(string factionName)
    {
        throw new NotImplementedException();
    }

    public void FindExpansionBySystem(string systemName)
    {
        throw new NotImplementedException();
    }

    public void FindExpansionBySystem(string systemName, string factionName)
    {
        throw new NotImplementedException();
    }

    private void RunExpansionCalculation(string systemName)
    {
        throw new NotImplementedException();
    }

    private void RunDefaultMechanicExpansion(string systemName)
    {
        throw new NotImplementedException();
    }

    private void RunInvasionMechanicExpansion(string systemName)
    {
        throw new NotImplementedException();
    }

    public void RunReverseExpansionCheck(string systemName)
    {
        throw new NotImplementedException();
    }
}
