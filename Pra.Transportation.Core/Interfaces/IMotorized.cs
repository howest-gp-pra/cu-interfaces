using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Transportation.Core.Interfaces
{
    public interface IMotorized : IMovable
    {
        float AverageConsumption { get; set; }

        float ConsumptionDuringLastTrip { get; }
    }
}
