using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class GeographicDisplayStrategy : IDisplayStrategy
    {
        public GeographicDisplayStrategy()
        {

        }
        public string Display()
        {
            return "This is Geographic Display :)";
        }
    }
}
