using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S._0___Problem
{
    internal class OrderService
    {
        // Rompe el principio de responsabilidad única
        // porque si modifico el método InsertOrder o CreateInvoice o EmailInvoce o WriteAllText
        // ya no tengo una responsabilidad única

        // Demasiadas responsabilidades para una clase
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);
                
                var invoice = this.CreateInvoice(order);

                this.EmailInvoice(invoice);

                File.WriteAllText(@"c:\InfoLog.txt", "The order has been complete");
            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", e.Message);
            }
        }

        public bool InsertOrder(Order order)
        {
            // Code to Insert the Ornder on the database
            return true;
        }

        public Invoice CreateInvoice(Order order)
        {
            // Code to Create Invoice
            return new Invoice();
        }

        public bool EmailInvoice(Invoice invoice)
        {
            // Code to email Invoice
            return true;
        }
    }

    public class Order
    {

    }

    public class Invoice 
    {
    }
}
