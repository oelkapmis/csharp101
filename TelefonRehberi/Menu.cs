using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public static class Menu
    {
        public static string run()
        {
            displayMenuMessage();
            return getUserChoice();
        }

        private static void displayMenuMessage()
        {

            string message = @"Lütfen yapmak istediğiniz işlemi seçiniz :
                              ******************************************
                              (1) Yeni Numara Kaydetmek
                              (2) Varolan Numarayı Silmek
                              (3) Varolan Numarayı Güncelleme
                              (4) Rehberi Listelemek
                              (5) Rehberde Arama Yapmak﻿";

            Console.WriteLine(message);
        }

        private static string getUserChoice()
        {
            string choice;

            try
            {
                choice = Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine("Invalid input!");
                choice = "-1";
            }
            return choice;
        }
    }
}
