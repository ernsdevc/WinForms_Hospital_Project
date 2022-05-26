using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ders7_Bolum_Doktor_Hasta.DAL;

namespace Ders7_Bolum_Doktor_Hasta.Forms
{
    public partial class frm_Rapor : Form
    {
        public frm_Rapor()
        {
            InitializeComponent();
        }

        private List<Hasta> hastalar; // this.hastalar

        public frm_Rapor(List<Hasta> hastalar)
        {
            this.hastalar = hastalar;
        }

        private void frm_Rapor_Load(object sender, EventArgs e)
        {
            int sira = 1;
            foreach (var item in hastalar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sira.ToString();
                lvi.SubItems.Add(item.BakilacagiBolum.ToString());
                lvi.SubItems.Add(item.HastaninDoktoru.ToString());
                lvi.SubItems.Add(item.AdSoyad);
                lvi.SubItems.Add(item.HastaninSikayeti);
                lvi.SubItems.Add(item.Kayittarihi.ToString());

                lst_randevu.Items.Add(lvi);
                sira++;
            }
        }
    }
}
