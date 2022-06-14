using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public static class UpdateUser
    {

        private static string info;
        private static int index;

        public static void run()
        {
            getUserInfo();
            getUserIndex();
            updateUser();
        }

        private static void updateUser()
        {
            if (index == -1)
            {
                Console.WriteLine(@" Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
                                 * Guncellemeyi sonlandırmak için : (1)
                                 * Yeniden denemek için      : (2)");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        return;
                    case "2":
                        UpdateUser.run();
                        return;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine($"{Program.list[index].firstName} {Program.list[index].lastName} isimli kişi icin yeni numarayi girin: ");
                string newPhone = Console.ReadLine();
                Program.list[index].phone = newPhone;
            }
        }

        private static void getUserIndex()
        {

            index = -1;

            for (int i = 0; i < Program.list.Count; i++)
            {
                if (Program.list[i].firstName == info || Program.list[i].lastName == info)
                {
                    index = i;
                    break;
                }
            }
        }

        private static void getUserInfo()
        {
            info = "";
            Console.WriteLine("  Lütfen numarasını guncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            info = Console.ReadLine();
        }
    }
}
