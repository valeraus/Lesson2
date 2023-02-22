using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно: Створити клас Invoice. 
    У тілі класу створити три поля int account, string customer, string provider, 
    які мають бути проініціалізовані один раз (при створенні екземпляра даного класу) 
    без можливості їхньої подальшої зміни. 
    У тілі класу створити два закриті поля string article, 
    int quantity Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ. 
    Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(678904, "Alex", "Foxtrot") { Article = "USB-hab", Quantity = 6 };

            inv.CostCalculation(true);
            inv.CostCalculation(false);

            Console.ReadKey();
        }
    }
}
