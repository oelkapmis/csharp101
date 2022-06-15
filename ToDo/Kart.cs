using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Kart
    {
        public string baslik;
        public string icerik;
        public int atananKisi;
        public Size buyukluk;

        public enum Size
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }

        public Kart(){}

        public Kart(string baslik, string icerik, int atananKisi, Size buyukluk)
        {
            this.baslik = baslik;
            this.icerik = icerik;
            this.atananKisi = atananKisi;
            this.buyukluk = buyukluk;
        }

    }
}
