using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___D._1___Solution
{
    // Dependency Inversion Principle

    // Se tiene que depender de abstracciones y no de clases concretas
    public class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            // Code to create an order

            // Send notification to datadog
            _eventNotificationService.LogEvent("The order was successfully created");
        }
    }

    public class Order
    {

    }
}
