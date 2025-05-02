using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S._1___Solution
{
    interface ILoggerService
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);

    }
    internal class LoggerService : ILoggerService
    {
        public void Debug(string info)
        {
           
        }

        public void Error(string message, Exception ex)
        {
            
        }

        public void Info(string info)
        {
        }
    }
}
