using _2_ci_task;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HOME_TASK_TO_17_AUG
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK 1
            List<User> Users = new List<User>();

            Users.Add(new User("onur", "ibadov", 23, "Azerbaijan"));
            Users.Add(new User("ruslan", "ibrahimov", 22, "Russia"));
            Users.Add(new User("nicat", "aliyev", 8, "Turkey"));
            Users.Add(new User("ayan", "huseynova", 6, "Ukraine"));
            Users.Add(new User("fidan", "kerimova", 19, "Turkey"));
            Users.Add(new User("feride", "mirzeyeva", 5, "Spain"));
            Users.Add(new User("nermin", "abdullayeva", 24, "Georgia"));
            Users.Add(new User("valeh", "veliyev", 3, "Zanzibar"));
            Users.Add(new User("ali", "memmedov", 24, "Turkey"));
            Users.Add(new User("cemil", "memmedov", 27 , "Ozbekistan"));


            Console.WriteLine("Find all users that age is greater than 20");
            Console.WriteLine("Print them as Name, Surname, Age, Country format.ex: {Parviz Parvizzada 21 Azerbaijan}\n");

            List<User> newlist1 = new List<User>();

            newlist1 = Users.Where(x => x.Age > 20).ToList();

            foreach (User list1_1 in newlist1)
            {
                Console.WriteLine(list1_1.Name + " " + list1_1.Surname + " " + list1_1.Age + " " + list1_1.Country);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Remove all users that belongs to Turkey and Age is lower than 10\n");


            #region Burdaki 2 metodda men REMOVE elediyimiz seyi sadece baska LISTE LISTE eledim

            List<User> newlist2 = new List<User>();
            newlist2 = Users.FindAll(x => x.Country == "Turkey" && x.Age < 10);
            for (var i = 0; i < newlist2.Count; i++)
            {
                Console.WriteLine(newlist2[i].Name + " " + newlist2[i].Surname + " " + newlist2[i].Age + " " + newlist2[i].Country);
            }

            List<User> newlist3 = new List<User>();
            newlist3 = Users.Where(x => x.Age < 10 && x.Country == "Turkey").ToList();
            foreach (User list3_3 in newlist3)
            {
                Console.WriteLine(list3_3.Name + " " + list3_3.Surname + " " + list3_3.Age + " " + list3_3.Country +"\n ");
            }
            #endregion


            //Men bunu ozum bura atdim cunki yuxari atanda remove eliyir ve hecne vermir))

            Users.RemoveAll(x => x.Country == "Turkey");
            List<User> newlist4 = Users.Where(x => x.Age < 10).ToList();

            foreach (User list4_4 in newlist4)
            {
                Console.WriteLine(list4_4.Name + " " + list4_4.Surname + " " + list4_4.Age + " " + list4_4.Country);
            }

            Console.WriteLine("\n");
            #endregion


            #region TASK 2

            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();

            #endregion

        }
    }
}
