using Pra.Transportation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
