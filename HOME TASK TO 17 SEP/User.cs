using System;
using System.Collections.Generic;
using System.Text;

namespace HOME_TASK_TO_17_AUG
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public  string Country { get; set; }
            
        public void Fullname(string name, string surname)
        {
            Console.WriteLine(Name + " " + Surname);
        }
        public User(string name, string surname, int age, string country)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Country = country;
        }
    }
}
