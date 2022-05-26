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
    public partial class frm_Bolum : Form
    {
        public frm_Bolum()
        {
            InitializeComponent();
        }

        Bolum[] bolumler = new Bolum[0];

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Array.Resize(ref bolumler, bolumler.Count() + 1);
            Bolum b = new Bolum();
            b.BolumKodu = txt_bolumkodu.Text;
            b.BolumAdi = txt_bolumadi.Text;
            b.BolumAciklama = txt_aciklama.Text;

            bolumler[bolumler.Count() - 1] = b;

            temizle();
            MessageBox.Show("Bölüm bilgisi başarıyla kaydedildi.");
        }

        public void temizle()
        {
            txt_aciklama.Text = txt_bolumadi.Text = txt_bolumkodu.Text = "";
        }

        private void frm_Bolum_Load(object sender, EventArgs e)
        {

        }

        private void btn_gec_Click(object sender, EventArgs e)
        {
            frm_Doktor f = new frm_Doktor(bolumler.ToList());
            f.ShowDialog();
        }
    }
}
