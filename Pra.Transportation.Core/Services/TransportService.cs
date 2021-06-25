using Pra.Transportation.Core.Entities;
using Pra.Transportation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
            Bike bike = new Bike(30, "Eddy Merckx classic");
            Bike bike2 = new Bike(20, "Flandria");

            movables = new List<IMovable>
            {
                bike
            };

        }
    }
}
