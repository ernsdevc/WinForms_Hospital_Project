using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7_Bolum_Doktor_Hasta.DAL
{
    public class Doktor
    {

        public string DoktorAdSoyad { get; set; }
        public Bolum DoktorunBolumu { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return DoktorAdSoyad.ToUpper();
        }

    }
}
