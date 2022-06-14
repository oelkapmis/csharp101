using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public static class DeleteUser
    {
        private static string info;
        private static int index;
        public static void run()
        {
            getUserInfo();
            getUserIndex();
            deleteUser();
        }

        private static void deleteUser()
        {
            if(index == -1)
            {
                Console.WriteLine(@" Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
                                 * Silmeyi sonlandırmak için : (1)
                                 * Yeniden denemek için      : (2)");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        return;
                    case "2":
                        DeleteUser.run();
                        return;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine($"{Program.list[index].firstName} {Program.list[index].lastName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "y":
                    case "Y":
                        Program.list.RemoveAt(index);
                        return;
                }
            }
        }

        private static void getUserIndex()
        {

            index = -1;

            for(int i = 0; i < Program.list.Count; i++)
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
            Console.WriteLine("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            info = Console.ReadLine();
        }
    }
}
