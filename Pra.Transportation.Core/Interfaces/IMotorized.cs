using System;

namespace Pra.Transportation.Core.Interfaces
{
    public interface IMotorized : IMovable
    {
        float AverageConsumption { get; set; }

        float ConsumptionDuringLastTrip { get; }
    }
}
