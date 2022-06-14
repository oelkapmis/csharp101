using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public static class SearchUser
    {
        private static string searchInfo;
        private static string userInfo;

        public static void run()
        {
            getSearchInfo();
            getUserInfo();
            searchUser();
        }

        private static void searchUser()
        {
            Console.WriteLine(@" Arama Sonuçlarınız:
 **********************************************");

            if(searchInfo == "1")
            {
                foreach (Person person in Program.list)
                {
                    if (person.firstName == userInfo || person.lastName == userInfo)
                    {
                        Console.WriteLine($"isim: {person.firstName}");
                        Console.WriteLine($"soyisim: {person.lastName}");
                        Console.WriteLine($"telefon numarasi: {person.phone}");
                        Console.WriteLine($"-");
                    }
                }
            }
            else if(searchInfo == "2")
            {
                foreach (Person person in Program.list)
                {
                    if (person.phone.Contains(userInfo))
                    {
                        Console.WriteLine($"isim: {person.firstName}");
                        Console.WriteLine($"soyisim: {person.lastName}");
                        Console.WriteLine($"telefon numarasi: {person.phone}");
                        Console.WriteLine($"-");
                    }
                }
            }

        }

        private static void getSearchInfo()
        {
            Console.WriteLine(@" Arama yapmak istediğiniz tipi seçiniz.
 **********************************************
 
 İsim veya soyisime göre arama yapmak için: (1)
 Telefon numarasına göre arama yapmak için: (2)");

            searchInfo = "";
            searchInfo = Console.ReadLine();
        }

        private static void getUserInfo()
        {
            if(searchInfo == "1")
            {
                userInfo = "";
                Console.WriteLine("Isim ya da soyisim girin: ");
                userInfo = Console.ReadLine();
            }
            else if(searchInfo == "2")
            {
                userInfo = "";
                Console.WriteLine("Telefon numarasi girin: ");
                userInfo = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            
        }
    }
}
