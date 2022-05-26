using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7_Bolum_Doktor_Hasta.DAL
{
    public class Bolum
    {
        public string BolumKodu { get; set; }
        public string BolumAdi { get; set; }
        public string BolumAciklama { get; set; }

        public override string ToString()
        {
            return BolumAdi.ToUpper();
        }

    }
}
