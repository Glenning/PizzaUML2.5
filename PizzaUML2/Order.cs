using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUML2
{
    public class Order
    {
        private int _orderId;
        public Pizza _pizza;
        public Customer _customer;
        private string _cart;
        private int _orderNumber;
        public Order()
        {
            _cart = "";
        }
        Order(Pizza pizza, Customer customer, int orderNumber)
        {
            _orderNumber = orderNumber;
        }
    }
}
