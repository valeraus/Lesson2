using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask1
{
    internal class User
    {
        string login, name, surname;
        int age;
        public readonly DateTime dateOfAncets;
        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                    return "Поле не заполнено";
                return login;
            }
        }
        public string Name
        {
            set { name = value; }
            get
            {
                if (name == null)
                    return "Поле не заполнено";
                return name;
            }
        }
        public string Surname
        {
            set { surname = value; }
            get
            {
                if (surname == null)
                    return "Поле не заполнено";
                return surname;
            }
        }
        public int Age
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                    return 25;
                return age;
            }
        }
        public DateTime DateOfAncets
        {
            get
            {
                return dateOfAncets;
            }
        }
        public User()
        {
            dateOfAncets = DateTime.Now;
        }
        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            dateOfAncets = DateTime.Now;
        }
    }
}
