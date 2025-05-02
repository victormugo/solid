using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S._1___Solution
{
    interface IOrderRepository
    {
        public bool InsertOrder(Order order);
    }

    internal class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            // Code to Insert the Order on the database
            return true;
        }
    }
}
