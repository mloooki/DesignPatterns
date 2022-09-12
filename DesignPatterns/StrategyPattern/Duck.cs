using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Duck
    {
        private IFlyStrategy _flyStrategy;
        private IDisplayStrategy _displayStrategy;
        public Duck(IFlyStrategy flyStrategy, IDisplayStrategy displayStrategy)
        {
            _flyStrategy = flyStrategy;
            _displayStrategy = displayStrategy;
        }
        public void SetFlyStrategy(IFlyStrategy flyStrategy) // This method to change the strategy dyncamiclly . (we can change the strategy it in run time)
        {
            _flyStrategy = flyStrategy;
        }
        public void SetDisplayStrategy(IDisplayStrategy DisplayStrategy) // This method to change the strategy dyncamiclly . (we can change the strategy it in run time)
        {
            _displayStrategy = DisplayStrategy;
        }
        public string InvokeFly()
        {
            return _flyStrategy.Fly();
        }

        public string InvokeDisplay()
        {
            return _displayStrategy.Display();
        }
    }
}
