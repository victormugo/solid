using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___I._0___Problem
{
    internal interface IFoodOrderService
    {
        void OrderBurguer(int quantity);
        void OrderSteak(int quantity);
        void OrderSalad(int quantity);
    }
}
