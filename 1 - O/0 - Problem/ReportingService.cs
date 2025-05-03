using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O._0___Problem
{
    internal class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType type)
        {
            // Generic code to create report

            // Specific conversion depending on type

            if (type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType.EXCEL)
            {
                CreateExcelReport(orders);
            }
        }

        public void CreatePDFReport(List<Order> orders)
        {
        }

        public void CreateExcelReport(List<Order> orders)
        {
        }
    }

    public class Order
    {

    }

    public enum ReportType
    {
        PDF,
        EXCEL
    }
}
