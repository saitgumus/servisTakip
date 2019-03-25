namespace DXApplication1
{
    partial class FrmSoforEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoforEkle));
            this.txt_soforSoyad = new System.Windows.Forms.TextBox();
            this.txt_soforAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soforMaas = new System.Windows.Forms.TextBox();
            this.Btn_YeniOgrenciKayitIptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YeniOgrenciKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_soforSoyad
            // 
            this.txt_soforSoyad.Location = new System.Drawing.Point(153, 139);
            this.txt_soforSoyad.Name = "txt_soforSoyad";
            this.txt_soforSoyad.Size = new System.Drawing.Size(145, 22);
            this.txt_soforSoyad.TabIndex = 21;
            // 
            // txt_soforAd
            // 
            this.txt_soforAd.Location = new System.Drawing.Point(153, 104);
            this.txt_soforAd.Name = "txt_soforAd";
            this.txt_soforAd.Size = new System.Drawing.Size(145, 22);
            this.txt_soforAd.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "maaş";
            // 
            // txt_soforMaas
            // 
            this.txt_soforMaas.Location = new System.Drawing.Point(153, 173);
            this.txt_soforMaas.Name = "txt_soforMaas";
            this.txt_soforMaas.Size = new System.Drawing.Size(145, 22);
            this.txt_soforMaas.TabIndex = 21;
            this.txt_soforMaas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_kontrol_KeyUp);
            // 
            // Btn_YeniOgrenciKayitIptal
            // 
            this.Btn_YeniOgrenciKayitIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKayitIptal.ImageOptions.Image")));
            this.Btn_YeniOgrenciKayitIptal.Location = new System.Drawing.Point(153, 281);
            this.Btn_YeniOgrenciKayitIptal.Name = "Btn_YeniOgrenciKayitIptal";
            this.Btn_YeniOgrenciKayitIptal.Size = new System.Drawing.Size(145, 38);
            this.Btn_YeniOgrenciKayitIptal.TabIndex = 25;
            this.Btn_YeniOgrenciKayitIptal.Text = "iptal/kapat";
            this.Btn_YeniOgrenciKayitIptal.Click += new System.EventHandler(this.Btn_YeniOgrenciKayitIptal_Click);
            // 
            // Btn_YeniOgrenciKaydet
            // 
            this.Btn_YeniOgrenciKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKaydet.ImageOptions.Image")));
            this.Btn_YeniOgrenciKaydet.Location = new System.Drawing.Point(153, 229);
            this.Btn_YeniOgrenciKaydet.Name = "Btn_YeniOgrenciKaydet";
            this.Btn_YeniOgrenciKaydet.Size = new System.Drawing.Size(145, 42);
            this.Btn_YeniOgrenciKaydet.TabIndex = 26;
            this.Btn_YeniOgrenciKaydet.Text = "kaydet";
            this.Btn_YeniOgrenciKaydet.Click += new System.EventHandler(this.Btn_YeniOgrenciKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "YENİ ŞOFÖR EKLE";
            // 
            // FrmSoforEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 416);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_YeniOgrenciKayitIptal);
            this.Controls.Add(this.Btn_YeniOgrenciKaydet);
            this.Controls.Add(this.txt_soforMaas);
            this.Controls.Add(this.txt_soforSoyad);
            this.Controls.Add(this.txt_soforAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSoforEkle";
            this.Text = "FrmSoforEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_soforSoyad;
        private System.Windows.Forms.TextBox txt_soforAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soforMaas;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKayitIptal;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKaydet;
        private System.Windows.Forms.Label label7;
    }
}