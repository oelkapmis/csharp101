using System;

namespace ToDo
{
    public static class Program
    {
        static void Main(string[] args)
        {
            initBoard();
            while(true)
                showMenu();
        }

        private static void showMenu()
        {
            Console.WriteLine(@"  Lütfen yapmak istediğiniz işlemi seçiniz : 
  * ******************************************
  (1) Board Listelemek
  (2) Board'a Kart Eklemek
  (3) Board'dan Kart Silmek
  (4) Kart Taşımak");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    boardListele();
                    break;
                case 2:
                    kartEkle();
                    break;
                case 3:
                    kartSil();
                    break;
                case 4:
                    kartTasi();
                    break;
            }
        }

        private static void kartTasi()
        {
            Console.WriteLine(@" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.
 Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();
            Kart kart = getFirstCardOrNull(baslik);

            if (kart != null)
            {
                deleteFirstCard(baslik);

                Console.WriteLine(@" Bulunan Kart Bilgileri:
 **************************************");
                Console.WriteLine($"Başlık      : {kart.baslik}");
                Console.WriteLine($"İçerik      : {kart.icerik}");
                Console.WriteLine($"Atanan Kişi : {Kisi.getPersonNameById(kart.atananKisi)}");
                Console.WriteLine($"Büyüklük    : {kart.buyukluk}");
                Console.WriteLine(@" Lütfen taşımak istediğiniz Line'ı seçiniz: 
 (1) TODO
 (2) IN PROGRESS
 (3) DONE");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Board.toDoList.Add(kart);
                        Console.WriteLine("Kart TO DO listesine basariyla eklendi!");
                        break;
                    case "2":
                        Board.inProgressList.Add(kart);
                        Console.WriteLine("Kart IN PROGRESS listesine basariyla eklendi!");
                        break;
                    case "3":
                        Board.doneList.Add(kart);
                        Console.WriteLine("Kart DONE listesine basariyla eklendi!");
                        break;
                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        break;
                }

            }
            else
            {
                Console.WriteLine(@"Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.
 * Silmeyi sonlandırmak için : (1)
 * Yeniden denemek için : (2)");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 2) kartTasi();
            }
        }

        private static void kartSil()
        {
            Console.WriteLine(@" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.
 Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();
            if (getFirstCardOrNull(baslik) != null)
            {
                Board.toDoList.RemoveAll(kart => kart.baslik == baslik);
                Board.inProgressList.RemoveAll(kart => kart.baslik == baslik);
                Board.doneList.RemoveAll(kart => kart.baslik == baslik);

                Console.WriteLine($"\"{baslik}\" baslikli not/notlar basariyla silindi!");
            }
            else
            {
                Console.WriteLine(@"Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.
 * Silmeyi sonlandırmak için : (1)
 * Yeniden denemek için : (2)");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 2) kartSil();
            }
            
        }

        private static Kart getFirstCardOrNull(string? baslik)
        {
            foreach (Kart kart in Board.toDoList)
                if (kart.baslik == baslik) return kart;
            foreach (Kart kart in Board.inProgressList)
                if (kart.baslik == baslik) return kart;
            foreach (Kart kart in Board.doneList)
                if (kart.baslik == baslik) return kart;

            return null;
        }

        private static void deleteFirstCard(string baslik)
        {
            foreach (Kart kart in Board.toDoList)
            {
                if (kart.baslik == baslik)
                {
                    Board.toDoList.Remove(kart);
                    return;
                }
            }
            foreach (Kart kart in Board.inProgressList)
            {
                if (kart.baslik == baslik)
                {
                    Board.toDoList.Remove(kart);
                    return;
                }
            }
            foreach (Kart kart in Board.doneList)
            {
                if (kart.baslik == baslik)
                {
                    Board.toDoList.Remove(kart);
                    return;
                }
            }
        }

        private static void kartEkle()
        {
            Kart yeniKart = new Kart();

            Console.WriteLine("Başlık Giriniz : ");
            yeniKart.baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz :");
            yeniKart.icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            yeniKart.buyukluk = (Kart.Size)int.Parse(Console.ReadLine()); //int degeri enum'a kast yaparak atamayi gerceklestiriyoruz
            Console.WriteLine("Kişi Seçiniz (ID numarasi ile) : ");
            yeniKart.atananKisi = int.Parse(Console.ReadLine());

            if(Kisi.getPersonNameById(yeniKart.atananKisi) == "Bulunamadi")
                Console.WriteLine("Hatalı girişler yaptınız!");
            else
                Board.toDoList.Add(yeniKart);
        }

        private static void boardListele()
        {
            Console.WriteLine(@" TODO Line
 ************************");
            if(Board.toDoList.Count == 0) Console.WriteLine("~ BOŞ ~");
            else foreach (Kart kart in Board.toDoList)
            {
                Console.WriteLine($"Başlık      : {kart.baslik}");
                Console.WriteLine($"İçerik      : {kart.icerik}");
                Console.WriteLine($"Atanan Kişi : {Kisi.getPersonNameById(kart.atananKisi)}");
                Console.WriteLine($"Büyüklük    : {kart.buyukluk}");
                Console.WriteLine("-");
            }

            Console.WriteLine(@" IN PROGRESS Line
 ************************");
            if (Board.inProgressList.Count == 0) Console.WriteLine("~ BOŞ ~");
            else foreach (Kart kart in Board.inProgressList)
            {
                Console.WriteLine($"Başlık      : {kart.baslik}");
                Console.WriteLine($"İçerik      : {kart.icerik}");
                Console.WriteLine($"Atanan Kişi : {Kisi.getPersonNameById(kart.atananKisi)}");
                Console.WriteLine($"Büyüklük    : {kart.buyukluk}");
                Console.WriteLine("-");
            }

            Console.WriteLine(@" DONE Line
 ************************");
            if (Board.doneList.Count == 0) Console.WriteLine("~ BOŞ ~");
            else foreach (Kart kart in Board.doneList)
            {
                Console.WriteLine($"Başlık      : {kart.baslik}");
                Console.WriteLine($"İçerik      : {kart.icerik}");
                Console.WriteLine($"Atanan Kişi : {Kisi.getPersonNameById(kart.atananKisi)}");
                Console.WriteLine($"Büyüklük    : {kart.buyukluk}");
                Console.WriteLine("-");
            }
        }

        private static void initBoard()
        {
            //  KART LISTELERINE NOT EKLE
            Board.toDoList.Add(new Kart("Matematik odevi", "Carsambaya kadar yetistirilecek", 1, Kart.Size.L));
            Board.toDoList.Add(new Kart("Konser", "Konser icin repertuvar hazirliklarini tamamla", 2, Kart.Size.S));
            Board.doneList.Add(new Kart("Market alisverisi", "Eve 2 kg patates ve yumurta al", 3, Kart.Size.M));

            //  TAKIMA KISI EKLE
            Board.takim.Add(new Kisi(1, "Audrey Jensen"));
            Board.takim.Add(new Kisi(2, "Alice Cullen"));
            Board.takim.Add(new Kisi(3, "Mark Zuckerberg"));
            Board.takim.Add(new Kisi(4, "Elon Musk"));
            Board.takim.Add(new Kisi(5, "Vladimir Putin"));
        }


    }
}