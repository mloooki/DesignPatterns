using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Animal
    {
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        abstract public bool isMarmmal();
        abstract public string GetAllInfo();
    }
}
