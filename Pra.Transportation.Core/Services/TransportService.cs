using System;
using System.Collections.Generic;
using Pra.Transportation.Core.Entities;
using Pra.Transportation.Core.Interfaces;

namespace Pra.Transportation.Core.Services
{
    public class TransportService
    {
        private List<IMovable> movables;

        public IEnumerable<IMovable> Movables 
        { 
            get
            {
                return movables.AsReadOnly();
            }
        }

        public TransportService()
        {
            SeedData();
        }

        private void SeedData()
        {
            // Seed movables
            Bike merckx = new Bike(30, "Eddy Merckx classic");
            Bike flandria = new Bike(20, "Flandria");
            Car daf = new Car(60, "Daf Variomatic", 5.5F);
            Car sportsCar = new Car(320, "Bugatti Veyron", 23.3F);

            movables = new List<IMovable>
            {
                merckx, flandria, daf, sportsCar
            };

        }
    }
}
