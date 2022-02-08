using System.Runtime.Serialization;

namespace EDCalculations.APIs;

[Serializable]
public sealed class NullDataException : Exception
{
    public NullDataException(string? message) : base(message) { }

    private NullDataException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
