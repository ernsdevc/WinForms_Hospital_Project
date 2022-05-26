
namespace Ders7_Bolum_Doktor_Hasta.Forms
{
    partial class frm_Bolum
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
            this.txt_bolumkodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bolumadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_gec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÖLÜM BİLGİLERİ GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "BÖLÜM KODU";
            // 
            // txt_bolumkodu
            // 
            this.txt_bolumkodu.Location = new System.Drawing.Point(399, 120);
            this.txt_bolumkodu.Name = "txt_bolumkodu";
            this.txt_bolumkodu.Size = new System.Drawing.Size(100, 20);
            this.txt_bolumkodu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "BÖLÜM ADI";
            // 
            // txt_bolumadi
            // 
            this.txt_bolumadi.Location = new System.Drawing.Point(399, 178);
            this.txt_bolumadi.Name = "txt_bolumadi";
            this.txt_bolumadi.Size = new System.Drawing.Size(155, 20);
            this.txt_bolumadi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "AÇIKLAMA";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(399, 232);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(155, 20);
            this.txt_aciklama.TabIndex = 6;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Green;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.Location = new System.Drawing.Point(132, 334);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(180, 66);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_gec
            // 
            this.btn_gec.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_gec.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gec.Location = new System.Drawing.Point(415, 334);
            this.btn_gec.Name = "btn_gec";
            this.btn_gec.Size = new System.Drawing.Size(170, 66);
            this.btn_gec.TabIndex = 8;
            this.btn_gec.Text = ">>";
            this.btn_gec.UseVisualStyleBackColor = false;
            this.btn_gec.Click += new System.EventHandler(this.btn_gec_Click);
            // 
            // frm_Bolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gec);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_bolumadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bolumkodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Bolum";
            this.Text = "frm_Bolum";
            this.Load += new System.EventHandler(this.frm_Bolum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bolumkodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bolumadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_gec;
    }
}