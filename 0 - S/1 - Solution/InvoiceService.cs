using SOLID._0___S._0___Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S._1___Solution
{
    interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }

    internal class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            return new Invoice();
        }
    }
}
