using Pra.Transportation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.Transportation.Core.Entities
{
    public class Person : IMovable, INamable
    {
        private List<INamable> responsibleFor = new List<INamable>();

        public IEnumerable<INamable> ResponsibleFor
        {
            get { return responsibleFor.AsReadOnly(); }
        }

        public bool HasResponsibilities
        {
            get { return responsibleFor.Count > 0; }
        }

        public float AverageSpeed { get; } = 5;

        public string TransportationInfo
        {
            get { return "Te voet"; }
        }

        private List<string> trips = new List<string>();

        public IEnumerable<string> Trips
        {
            get { return trips.AsReadOnly(); }
        }

        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Go(float distance, IMovable transport)
        {
            if (transport == null)
                throw new Exception("Geef een transportmiddel door.");

            if (distance <= 0)
                throw new Exception("Geef een positief getal in voor de afstand.");

            TimeSpan duration = transport.Move(distance);

            StringBuilder logBuilder = new StringBuilder();
            logBuilder.AppendLine(DateTime.Now.ToString("[dd MMM HH:mm]"));
            logBuilder.AppendLine($"{distance} km: {(int)duration.TotalMinutes} min.");
            logBuilder.AppendLine($"{transport.TransportationInfo}");
            if (transport is IMotorized motorized)
                logBuilder.AppendLine($"Verbruik: {motorized.ConsumptionDuringLastTrip:0.00} l.");

            logBuilder.Append('-', 30);

            trips.Insert(0, logBuilder.ToString());
        }

        public TimeSpan Move(float kilometers)
        {
            float hoursWalked = kilometers / AverageSpeed;
            return TimeSpan.FromHours(hoursWalked);
        }

        public bool AssumeResponsibility(INamable creature)
        {
            if (creature == null)
                throw new Exception("Geef een wezen door om verantwoordelijkheid over op te nemen.");
            if (creature == this)
                throw new Exception("Je bent sowieso verantwoordelijk voor jezelf.");
            if (!responsibleFor.Contains(creature))
            {
                responsibleFor.Add(creature);
                return true;
            }
            return false;
        }

        public string ShowResponsibilities()
        {
            if (HasResponsibilities)
            {
                StringBuilder stringBuilder = new StringBuilder("Verantwoordelijk voor: \n");
                foreach (INamable creature in ResponsibleFor)
                {
                    stringBuilder.AppendLine(creature.Name);
                }
                return stringBuilder.ToString();
            }
            else
            {
                return "";
            }
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
