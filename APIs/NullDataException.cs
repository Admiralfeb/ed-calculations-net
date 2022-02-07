namespace EDCalculations.APIs;

public sealed class NullDataException : Exception
{
    public NullDataException(string? message) : base(message) { }
}
