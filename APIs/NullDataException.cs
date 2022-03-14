using System.Runtime.Serialization;

namespace UnitedSystemsCooperative.Utils.EDCalc.APIs;

[Serializable]
public sealed class NullDataException : Exception
{
    public NullDataException(string? message) : base(message)
    {
    }

    private NullDataException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}