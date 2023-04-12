using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    public class MenuCatalog
    {
        private string menuItems;
        //public int MenuChoice(List <string> menuItems)
        List<Pizza> _pizzas;
        public MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }
        public void PrintMenu()
        {
            foreach (Pizza pizza in _pizzas) 
            {
                Console.WriteLine(pizza);
            }
        }
    }
}
