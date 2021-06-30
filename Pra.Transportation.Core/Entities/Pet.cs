using System;
using Pra.Transportation.Core.Interfaces;

namespace Pra.Transportation.Core.Entities
{
    public class Pet : INamable
    {
        public string Name { get; set; }

        public Pet(string name)
        {
            Name = name;
        }
    }

}
