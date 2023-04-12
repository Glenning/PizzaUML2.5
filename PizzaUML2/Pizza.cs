using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    public class Pizza
    {
        public string pizzaName { get; set; }
        public double pizzaPrice { get; set; }
        public int number { get; set; }

        public override string ToString()
        {
            return pizzaName + " " + pizzaPrice + "kr";
        }
    }
}
