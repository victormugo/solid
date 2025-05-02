﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S._1___Solution
{
    internal class OrderService
    {
        // Single Responsability Principle

        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;
        private readonly IInvoiceService _invoiceService;
        private readonly ILoggerService _loggerService;

        public OrderService(IOrderRepository orderRepository, 
            INotificationService notificationService,
            IInvoiceService invoiceService, 
            ILoggerService loggerService)
        {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
            _invoiceService = invoiceService;
            _loggerService = loggerService;
        }

        public void SaveOrder(Order order)
        {
            try
            {
                _orderRepository.InsertOrder(order);

                var invoice = _invoiceService.CreateInvoice(order);

                _notificationService.EmailInvoice(invoice);

                _loggerService.Info("The order has been completed");
            }
            catch (Exception e)
            {
                _loggerService.Error(e.Message, e); 
            }
        }
    }
}
