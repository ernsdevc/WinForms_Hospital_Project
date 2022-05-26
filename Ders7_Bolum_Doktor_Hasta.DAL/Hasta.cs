using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7_Bolum_Doktor_Hasta.DAL
{
    public class Hasta
    {

        public string AdSoyad { get; set; }
        public Bolum BakilacagiBolum { get; set; }
        public Doktor HastaninDoktoru { get; set; }
        public string HastaninSikayeti { get; set; }


        public DateTime Kayittarihi
        {
            get
            {
                return DateTime.Now;
            }
        }

    }
}
