using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Transportation.Core.Entities
{
    public class Car : Movable
    {

        public Car(float averageSpeed, string type, float averageConsumption) : base(averageSpeed, type)
        {
            
        }

        public override TimeSpan Move(float kilometers)
        {
            // Efectieve implementatie volgt verder
            return new TimeSpan(0);
        }
    }
}
