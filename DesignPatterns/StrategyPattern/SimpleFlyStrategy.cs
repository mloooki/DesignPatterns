using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class SimpleFlyStrategy : IFlyStrategy
    {
        public SimpleFlyStrategy()
        {

        }
        public string Fly()
        {
            return "This is Simple Fly";
        }
    }
}
