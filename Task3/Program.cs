using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно створити клас Employee. 
    У тілі класу створити користувальницький конструктор, який приймає два рядкові аргументи, 
    та ініціалізує поля, що відповідають прізвищу та імені співробітника. 
    Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) та податковий збір. 
    Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), 
    оклад та податковий збір. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Smith", "Petr");
            employee.Post = "manager";
            employee.Experience = 1;

            Console.WriteLine(employee.Surname + " " + employee.Name + " " + employee.Post.ToUpper());
            employee.ShowSalary();

            Console.ReadKey();
        }
    }
}
