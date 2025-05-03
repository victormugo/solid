using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___D._0___Problem
{
    public class DataDogService
    {
        public void LogEvent(string message)
        {
            // Code to event on DataDog
        }
    }

    public class OrderService
    {
        public readonly DataDogService _datadogService;

        public OrderService(DataDogService datadogService)
        {
            _datadogService = datadogService;
        }

        public void GenerateOrder(Order order)
        {
            // Code to create an Order

            _datadogService.LogEvent("The order was successfully created");
        }
    }

    public class Order
    {

    }
}
