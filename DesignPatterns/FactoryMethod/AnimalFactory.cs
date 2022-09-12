using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class AnimalFactory
    {
        public AnimalFactory()
        {

        }
        public Animal CreateAnimal(string ThisIsVeryComplexObjectToDetermineTheAnimalWeShouldCreate)
        {
            if (ThisIsVeryComplexObjectToDetermineTheAnimalWeShouldCreate.Count() == 1)
                return new Zebra(1, 20, "Female", false);

            else if (ThisIsVeryComplexObjectToDetermineTheAnimalWeShouldCreate.Count() == 0)
                return new Fish(2, 40, "Male", 3, true, false);

            else
                return new Duck("Green", "Female", 3, 6);
        }
    }
}
