
namespace Ders7_Bolum_Doktor_Hasta.Forms
{
    partial class frm_Doktor
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_doktoradi_soyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_bolumler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Gec = new System.Windows.Forms.Button();
            this.lst_Doktorlar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOKTOR BİLGİLERİ GİRİŞ FORMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOKTOR AD SOYAD";
            // 
            // txt_doktoradi_soyadi
            // 
            this.txt_doktoradi_soyadi.Location = new System.Drawing.Point(420, 85);
            this.txt_doktoradi_soyadi.Name = "txt_doktoradi_soyadi";
            this.txt_doktoradi_soyadi.Size = new System.Drawing.Size(179, 20);
            this.txt_doktoradi_soyadi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "BÖLÜMÜ";
            // 
            // cmb_bolumler
            // 
            this.cmb_bolumler.FormattingEnabled = true;
            this.cmb_bolumler.Location = new System.Drawing.Point(420, 140);
            this.cmb_bolumler.Name = "cmb_bolumler";
            this.cmb_bolumler.Size = new System.Drawing.Size(168, 21);
            this.cmb_bolumler.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "TC";
            // 
            // mtxt_TC
            // 
            this.mtxt_TC.Location = new System.Drawing.Point(420, 198);
            this.mtxt_TC.Mask = "000 000 00 000";
            this.mtxt_TC.Name = "mtxt_TC";
            this.mtxt_TC.Size = new System.Drawing.Size(168, 20);
            this.mtxt_TC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "TELEFON";
            // 
            // mtxt_telefon
            // 
            this.mtxt_telefon.Location = new System.Drawing.Point(420, 248);
            this.mtxt_telefon.Mask = "(999) 000-00-00";
            this.mtxt_telefon.Name = "mtxt_telefon";
            this.mtxt_telefon.Size = new System.Drawing.Size(168, 20);
            this.mtxt_telefon.TabIndex = 8;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kaydet.Location = new System.Drawing.Point(159, 342);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(193, 71);
            this.btn_Kaydet.TabIndex = 9;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Gec
            // 
            this.btn_Gec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Gec.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gec.Location = new System.Drawing.Point(420, 342);
            this.btn_Gec.Name = "btn_Gec";
            this.btn_Gec.Size = new System.Drawing.Size(168, 71);
            this.btn_Gec.TabIndex = 10;
            this.btn_Gec.Text = ">>";
            this.btn_Gec.UseVisualStyleBackColor = false;
            this.btn_Gec.Click += new System.EventHandler(this.btn_Gec_Click);
            // 
            // lst_Doktorlar
            // 
            this.lst_Doktorlar.ContextMenuStrip = this.contextMenuStrip1;
            this.lst_Doktorlar.FormattingEnabled = true;
            this.lst_Doktorlar.Location = new System.Drawing.Point(698, 85);
            this.lst_Doktorlar.Name = "lst_Doktorlar";
            this.lst_Doktorlar.Size = new System.Drawing.Size(286, 238);
            this.lst_Doktorlar.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // frm_Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.lst_Doktorlar);
            this.Controls.Add(this.btn_Gec);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.mtxt_telefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxt_TC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_bolumler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_doktoradi_soyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Doktor";
            this.Text = "frm_Doktor";
            this.Load += new System.EventHandler(this.frm_Doktor_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_doktoradi_soyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_bolumler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxt_TC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxt_telefon;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Gec;
        private System.Windows.Forms.ListBox lst_Doktorlar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}