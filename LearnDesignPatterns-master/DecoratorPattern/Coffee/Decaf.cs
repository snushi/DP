using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Coffee
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        public override double Cost()
        {
            return 1.05;
        }

        public override string GetDescription()
        {
            return "Decaf Coffee";
        }
    }
}
