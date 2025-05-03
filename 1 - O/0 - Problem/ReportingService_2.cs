using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O._0___Problem
{
    internal class ReportingService_2
    {
        public void GenerateReport(List<Order> orders, ReportType_2 type)
        {
            // Generic code to create report

            // Specific conversion depending on type

            if (type == ReportType_2.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType_2.EXCEL)
            {
                CreateExcelReport(orders);
            }
            else if (type == ReportType_2.JSON)
            {
                CreateJSONReport(orders);
            }
            else if (type == ReportType_2.XML)
            {
                CreateXMLReport(orders);
            }
        }

        public void CreatePDFReport(List<Order> orders)
        {
        }

        public void CreateExcelReport(List<Order> orders)
        {
        }

        public void CreateJSONReport(List<Order> orders)
        {
        }

        public void CreateXMLReport(List<Order> orders)
        {
        }
    }

    public enum ReportType_2
    {
        PDF,
        EXCEL,
        JSON,
        XML
    }
}
