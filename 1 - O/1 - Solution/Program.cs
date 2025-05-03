using SOLID._1___O._0___Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O._1___Solution
{
    internal class Program
    {
        // Open - Close Principle
        // Capaz de extender el comportamiento de una clase sin modificar la misma clase
        public static void Main()
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService(new ReportGeneratorPDF());
            service.GenerateReport(orders);
        }
    }
}
