using System;
using System.Collections.Generic;
using TelefonRehberi;

namespace TelefonRehberi
{
    public static class Program
    {

        public static List<Person> list = new List<Person>();
        static void Main(string[] args)
        {
           initList();

            while (true)
            {
                string choice = Menu.run();

                switch (choice)
                {
                    case "1":
                        AddUser.run();
                        break;
                    case "2":
                        DeleteUser.run();
                        break;
                    case "3":
                        UpdateUser.run();
                        break;
                    case "4":
                        DisplayList.run();
                        break;
                    case "5":
                        SearchUser.run();
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        return;
                }
            }
        }

        private static void initList()
        {
            list.Add(new Person("Mert", "Yozgatli", "05051111111"));
            list.Add(new Person("Buse", "Tosun", "05342222222"));
            list.Add(new Person("Alp", "Sorgu", "05053333333"));
            list.Add(new Person("Elif", "Nikotin", "05324444444"));
            list.Add(new Person("Asya", "Yelvicin", "05465555555"));
        }
    }
}