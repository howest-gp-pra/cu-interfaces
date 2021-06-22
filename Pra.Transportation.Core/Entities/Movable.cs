using System;
using System.Collections.Generic;
using System.Text;
namespace Pra.Transportation.Core.Entities
{
    public abstract class Movable
    {
        protected static Random random = new Random();

        public TimeSpan TimePerKilometer
        {
            get
            {
                TimeSpan hour = TimeSpan.FromHours(1);
                return hour / AverageSpeed;
            }
        }

        public virtual string TransportationInfo
        {
            get { return $"{Model}\n\t{AverageSpeed} km/u."; }
        }

        public float AverageSpeed { get; set; }

        public string Model { get; set; }

        public Movable(float averageSpeed, string model)
        {
            AverageSpeed = averageSpeed;
            Model = model;
        }
        public abstract TimeSpan Move(float kilometers);

        public override string ToString()
        {
            return TransportationInfo;
        }
    }
}
