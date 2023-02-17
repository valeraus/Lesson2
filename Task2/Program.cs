using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: Створити клас Converter. 
    У тілі класу створити користувальницький конструктор, 
    який приймає три речові аргументи, і ініціалізує поля, що відповідають курсу 3-х основних валют, 
    по відношенню до гривні – public Converter (double usd, double eur, double rub). 
    Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют, 
    також програма повинна проводити конвертацію із зазначених валют у гривню. 
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(40, 41, 0.1);

            converter.ToUsd(100);
            converter.FromUsd(100);

            Console.ReadKey();
        }
    }
}
