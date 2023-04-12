using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    public class Store
    {
        MenuCatalog menuCatalog;
        public Store() 
        {
            menuCatalog = new MenuCatalog();
        }
        public void Test()
        {
            Pizza p1 = new Pizza() { pizzaName = "Margerita", pizzaPrice = 45, number = 1};
            menuCatalog.Create(p1);
            Pizza p2 = new Pizza() { pizzaName = "Diavolo", pizzaPrice = 55, number = 2 };
            menuCatalog.Create(p2);
            Pizza p3 = new Pizza() { pizzaName = "Hawaii", pizzaPrice = 50, number = 3 };
            menuCatalog.Create(p3);

            menuCatalog.PrintMenu();
        }
    }
}
