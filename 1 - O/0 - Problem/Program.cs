using SOLID._0___S._0___Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O._0___Problem
{
    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService();
            service.GenerateReport(orders, ReportType.PDF);
        }
    }
}
