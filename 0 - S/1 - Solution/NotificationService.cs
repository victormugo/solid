using SOLID._0___S._0___Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S._1___Solution
{
    interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }

    internal class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            return true;
        }
    }
}
