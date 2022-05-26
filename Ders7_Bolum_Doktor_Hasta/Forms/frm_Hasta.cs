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
using Ders7_Bolum_Doktor_Hasta.Forms;

namespace Ders7_Bolum_Doktor_Hasta
{
    public partial class frm_Hasta : Form
    {
        public frm_Hasta()
        {
            InitializeComponent();
        }

        List<Doktor> doktorlar;
        List<Bolum> bolumler;
        List<Hasta> hastalar = new List<Hasta>();

        public frm_Hasta(List<Doktor> doktorlar, List<Bolum> bolumler):this()
        {
            this.bolumler = bolumler;
            this.doktorlar = doktorlar;
        }

        private void frm_Hasta_Load(object sender, EventArgs e)
        {
            cmb_bolumler.DataSource = bolumler;
            cmb_doktorlar.Enabled = false; //form ilk açıldığında doktor seçilemesin
        }

        private void cmb_bolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktorlar.Enabled = true; // bölüm seçildikten sonra doktor seçilsin
            cmb_doktorlar.Items.Clear(); // önceki bölüme ait doktorları temizler

            Bolum secilenBolum = cmb_bolumler.SelectedItem as Bolum;

            foreach (Doktor item in doktorlar)
            {
                if (item.DoktorunBolumu.BolumKodu == secilenBolum.BolumKodu)
                {
                    cmb_bolumler.Items.Add(item);
                }
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            hastalar.Add(new Hasta() {
                AdSoyad = txt_hastaadi.Text,
                BakilacagiBolum = cmb_bolumler.SelectedItem as Bolum,
                HastaninDoktoru = cmb_doktorlar.SelectedItem as Doktor,
                HastaninSikayeti = txt_hastaninsikayeti.Text
            });
            temizle();
            MessageBox.Show("Hasta Kaydı Başarıyla Alınmıştır.");
        }

        public void temizle()
        {
            txt_hastaadi.Text = txt_hastaninsikayeti.Text = "";
        }

        private void btn_raporal_Click(object sender, EventArgs e)
        {
            frm_Rapor r = new frm_Rapor(hastalar);
            r.ShowDialog();
        }
    }
}
