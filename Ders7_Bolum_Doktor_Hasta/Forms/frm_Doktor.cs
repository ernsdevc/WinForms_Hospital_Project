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
    public partial class frm_Doktor : Form
    {
        public frm_Doktor()
        {
            InitializeComponent();
        }

        List<Bolum> bolumler = null;
        List<Doktor> doktorlar = new List<Doktor>();

        public frm_Doktor(List<Bolum> bolumler):this()
        {
            this.bolumler = bolumler;
        }

        private void frm_Doktor_Load(object sender, EventArgs e)
        {
            cmb_bolumler.DataSource = bolumler;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Doktor d = new Doktor();
            d.DoktorAdSoyad = txt_doktoradi_soyadi.Text;
            d.DoktorunBolumu = cmb_bolumler.SelectedItem as Bolum; // (Bolum)cmb_bolumler.SelectedItem olarak da kullanılır. Mantığı Convert'le aynı
            d.TC = mtxt_TC.Text;
            d.Telefon = mtxt_telefon.Text;
            doktorlar.Add(d);

            LİstboxaEkle(doktorlar);
            temizle();
            MessageBox.Show("Doktor kaydı başarıyla alınmıştır.");
        }

        public void temizle()
        {
            txt_doktoradi_soyadi.Text=mtxt_TC.Text=mtxt_telefon.Text="";
        }

        private void LİstboxaEkle(List<Doktor> doktorlar)
        {
            lst_Doktorlar.Items.Clear(); //tekrarlayan kayıt olmaması için temizleme
            lst_Doktorlar.Items.AddRange(doktorlar.ToArray());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var silinecekveri = lst_Doktorlar.SelectedItem as Doktor;
            lst_Doktorlar.Items.Remove(silinecekveri);
            doktorlar.Clear();

            foreach (Doktor item in lst_Doktorlar.Items)
            {
                doktorlar.Add(item);
            }
        }

        private void btn_Gec_Click(object sender, EventArgs e)
        {
            frm_Hasta f = new frm_Hasta(doktorlar,bolumler);
            f.ShowDialog();
        }
    }
}
