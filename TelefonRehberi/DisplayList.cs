using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public static class DisplayList
    {
        public static void run()
        {
            Console.WriteLine(@" Telefon Rehberi
  **********************************************");

            foreach(Person person in Program.list)
            {
                Console.WriteLine($"isim: {person.firstName}");
                Console.WriteLine($"soyisim: {person.lastName}");
                Console.WriteLine($"telefon numarasi: {person.phone}");
                Console.WriteLine($"-");
            }

        }
    }
}
