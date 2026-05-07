using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Coffee
{
    public class Espresso : Beverage
    {
        public Espresso() 
        {
            Description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
        public override string GetDescription()
        {
            return "Espresso Coffee";
        }
    }
}
