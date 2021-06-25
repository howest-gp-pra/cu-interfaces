using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Transportation.Core.Entities
{
    public class Bike : Movable
    {
        public Bike(float averageSpeed, string type) : base(averageSpeed, type)
        {

        }

        public override TimeSpan Move(float kilometers)
        {
            float windFactor = random.Next(80, 120) / 100F;
            return CalculateTripDuration(kilometers, windFactor);
        }
    }
}
