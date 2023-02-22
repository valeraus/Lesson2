using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask1
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    потрібно:
    Створити клас User, що містить інформацію про користувача 
    (логін, ім'я, прізвище, вік, дата заповнення анкети). 
    Поле дата заповнення анкети повинне бути проініціалізувати тільки один раз 
    (при створенні екземпляра даного класу) без можливості його подальшої зміни.
    Реалізуйте висновок на екран інформації про користувача.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine(user.dateOfAncets.ToString());
            Console.WriteLine(user.Surname);

            user.Surname = "Kostenko";
            Console.WriteLine(user.Surname);

            Console.WriteLine(new string('-', 20));

            User user2 = new User("DaShe", "Daria", "Shevchenko", 25);
            Console.WriteLine(user2.dateOfAncets.ToString());
            Console.WriteLine(user2.Login);
            Console.WriteLine(user2.Name);
            Console.WriteLine(user2.Surname);
            Console.WriteLine(user2.Age);

            Console.ReadKey();

        }
    }
}
