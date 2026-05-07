using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Coffee
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
        }
        public override double Cost()
        {
            return 0.99;
        }
        public override string GetDescription()
        {
            return "DarkRoast Coffee";
        }
    }
}
