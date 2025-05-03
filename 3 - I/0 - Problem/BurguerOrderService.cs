using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___I._0___Problem
{
    internal class BurguerOrderService : IFoodOrderService
    {
        public void OrderBurguer(int quantity)
        {
            // Code to Order a Burguer
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException("Can't order a salad in this service");
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException("Can't order a Steak in this service");
        }
    }
}
