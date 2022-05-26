
namespace Ders7_Bolum_Doktor_Hasta
{
    partial class frm_Hasta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hastaadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_bolumler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_doktorlar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hastaninsikayeti = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_raporal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA BİLGİLERİ GİRİŞ FORMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(222, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "HASTA ADI";
            // 
            // txt_hastaadi
            // 
            this.txt_hastaadi.Location = new System.Drawing.Point(374, 90);
            this.txt_hastaadi.Name = "txt_hastaadi";
            this.txt_hastaadi.Size = new System.Drawing.Size(177, 20);
            this.txt_hastaadi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(217, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "BÖLÜMLER";
            // 
            // cmb_bolumler
            // 
            this.cmb_bolumler.FormattingEnabled = true;
            this.cmb_bolumler.Location = new System.Drawing.Point(374, 148);
            this.cmb_bolumler.Name = "cmb_bolumler";
            this.cmb_bolumler.Size = new System.Drawing.Size(177, 21);
            this.cmb_bolumler.TabIndex = 4;
            this.cmb_bolumler.SelectedIndexChanged += new System.EventHandler(this.cmb_bolumler_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(185, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "DOKOTORLAR";
            // 
            // cmb_doktorlar
            // 
            this.cmb_doktorlar.FormattingEnabled = true;
            this.cmb_doktorlar.Location = new System.Drawing.Point(374, 214);
            this.cmb_doktorlar.Name = "cmb_doktorlar";
            this.cmb_doktorlar.Size = new System.Drawing.Size(177, 21);
            this.cmb_doktorlar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(121, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "HASTANIN ŞİKAYETİ";
            // 
            // txt_hastaninsikayeti
            // 
            this.txt_hastaninsikayeti.Location = new System.Drawing.Point(374, 273);
            this.txt_hastaninsikayeti.Multiline = true;
            this.txt_hastaninsikayeti.Name = "txt_hastaninsikayeti";
            this.txt_hastaninsikayeti.Size = new System.Drawing.Size(177, 121);
            this.txt_hastaninsikayeti.TabIndex = 8;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_kaydet.Location = new System.Drawing.Point(190, 427);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(173, 58);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_raporal
            // 
            this.btn_raporal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_raporal.Location = new System.Drawing.Point(556, 427);
            this.btn_raporal.Name = "btn_raporal";
            this.btn_raporal.Size = new System.Drawing.Size(154, 58);
            this.btn_raporal.TabIndex = 10;
            this.btn_raporal.Text = "RAPOR AL";
            this.btn_raporal.UseVisualStyleBackColor = false;
            this.btn_raporal.Click += new System.EventHandler(this.btn_raporal_Click);
            // 
            // frm_Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 497);
            this.Controls.Add(this.btn_raporal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_hastaninsikayeti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_doktorlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_bolumler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_hastaadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Hasta";
            this.Text = "frm_Hasta";
            this.Load += new System.EventHandler(this.frm_Hasta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hastaadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_bolumler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_doktorlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hastaninsikayeti;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_raporal;
    }
}