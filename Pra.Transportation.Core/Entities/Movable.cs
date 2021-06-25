using Pra.Transportation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Transportation.Core.Entities
{
    public abstract class Movable : IMovable
    {
        protected static Random random = new Random();

        public float AverageSpeed { get; set; }

        public virtual string TransportationInfo
        {
            get { return $"{Model}\n\t{AverageSpeed} km/u."; }
        }

        public TimeSpan TimePerKilometer
        {
            get
            {
                TimeSpan hour = TimeSpan.FromHours(1);
                return hour / AverageSpeed;
            }
        }

        public string Model { get; set; }

        public abstract TimeSpan Move(float kilometers);

        public Movable(float averageSpeed, string model)
        {
            AverageSpeed = averageSpeed;
            Model = model;
        }

        protected TimeSpan CalculateTripDuration(float kilometers, float speedFactor)
        {
            return TimePerKilometer * kilometers * speedFactor;
        }

        public override string ToString()
        {
            return TransportationInfo;
        }
    }
}
