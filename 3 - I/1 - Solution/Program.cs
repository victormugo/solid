using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___I._1___Solution
{
    // Interface Segregation Principle

    // Muchas interfaces especificas es mejor que una gran interfaz
    // La interfaz tiene que tener una finalizad muy concreta
    internal class Program
    {
        public static void Main()
        {
            BurgerOrderService burguerService = new BurgerOrderService();
            burguerService.OrderBurguer(2);

            SaladOrderService saladService = new SaladOrderService();
            saladService.OrderSalad(2);

            SteakOrderService steakOrderService = new SteakOrderService();
            steakOrderService.OrderSteak(2);
        }
    }
}
