using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public static class AddUser
    {
        public static void run()
        {
            Program.list.Add(getUserInfo());
        }


        private static Person getUserInfo()
        {
            Person person = new Person();
            Console.WriteLine(" Lütfen isim giriniz             :");
            person.firstName = Console.ReadLine();
            Console.WriteLine(" Lütfen soyisim giriniz          :");
            person.lastName = Console.ReadLine();
            Console.WriteLine(" Lütfen telefon numarası giriniz :");
            person.phone = Console.ReadLine();

            return person;
        }
    }
}
