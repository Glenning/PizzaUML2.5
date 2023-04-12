using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    public class Customer
    {
        private string _customerName;
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }
        public Customer(string customerName)
        {
            _customerName = customerName;
        }
    }
}
