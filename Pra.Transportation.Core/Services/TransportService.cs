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
        private List<Person> people;
        public IEnumerable<Person> People
        {
            get { return people.AsReadOnly(); }
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

            // Seed persons
            Person jack = new Person("Jack");
            Person john = new Person("John");
            Person jamie = new Person("Jamie");
            Person jenny = new Person("Jenny");

            people = new List<Person>
            {
                jack, john, jamie, jenny
            };

            movables.InsertRange(0, people);

            // Simulate trips
            john.Go(15.85F, merckx);
            jack.Go(115.85F, flandria);
            jenny.Go(1200F, sportsCar);
            jamie.Go(120.25F, sportsCar);
            jack.Go(150.85F, daf);
        }

        public List<IMovable> GetAvailableMovables(Person person)
        {
            List<IMovable> availableMovables = new List<IMovable>();
            foreach (IMovable movable in movables)
            {
                if (!(movable is Person) || movable == person)
                    availableMovables.Add(movable);
            }
            return availableMovables;
        }
    }
}
