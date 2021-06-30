using System;
using Pra.Transportation.Core.Interfaces;

namespace Pra.Transportation.Core.Entities
{
    public class Car : Movable, IMotorized
    {
        public float ConsumptionDuringLastTrip { get; private set; }

        public float AverageConsumption { get; set; }

        public override string TransportationInfo
        {
            get
            {
                return $"{base.TransportationInfo}\n\t{AverageConsumption} l/100 km.";
            }
        }

        public Car(float averageSpeed, string type, float averageConsumption) : base(averageSpeed, type)
        {
            AverageConsumption = averageConsumption;
        }

        public override TimeSpan Move(float kilometers)
        {
            int trafficFluency = random.Next(0, 51);
            float trafficInfluence = (100 + trafficFluency) / 100F;
            RegisterTripConsumption(kilometers);
            return CalculateTripDuration(kilometers, trafficInfluence);
        }

        private void RegisterTripConsumption(float kilometers)
        {
            ConsumptionDuringLastTrip = AverageConsumption * kilometers / 100;
        }

    }
}
