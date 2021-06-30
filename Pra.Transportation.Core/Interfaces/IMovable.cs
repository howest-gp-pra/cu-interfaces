using System;

namespace Pra.Transportation.Core.Interfaces
{
    public interface IMovable
    {
        float AverageSpeed { get; }
        string TransportationInfo { get; }
        TimeSpan Move(float kilometers);
    }
}
