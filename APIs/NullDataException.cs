namespace EDCalculations.APIs;

public class NullDataException : Exception
{
    public NullDataException(string? message) : base(message) { }
}
