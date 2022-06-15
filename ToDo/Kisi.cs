using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Kisi
    {
        int id;
        string name;

        public Kisi(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static string getPersonNameById(int id)
        {
            foreach(Kisi kisi in Board.takim)
            {
                if(kisi.id == id) return kisi.name;
            }

            return "Bulunamadi";
        }
    }
}
