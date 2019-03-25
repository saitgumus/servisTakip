namespace DXApplication1
{
    partial class FrmOkulTurEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOkulTurEkle));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_okulTurAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_YeniOgrenciKayitIptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YeniOgrenciKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_okulEgitimYili = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "eğitim yılı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "YENİ OKUL TÜRÜ";
            // 
            // txt_okulTurAd
            // 
            this.txt_okulTurAd.Location = new System.Drawing.Point(127, 121);
            this.txt_okulTurAd.Name = "txt_okulTurAd";
            this.txt_okulTurAd.Size = new System.Drawing.Size(145, 22);
            this.txt_okulTurAd.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "ad";
            // 
            // Btn_YeniOgrenciKayitIptal
            // 
            this.Btn_YeniOgrenciKayitIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKayitIptal.ImageOptions.Image")));
            this.Btn_YeniOgrenciKayitIptal.Location = new System.Drawing.Point(127, 288);
            this.Btn_YeniOgrenciKayitIptal.Name = "Btn_YeniOgrenciKayitIptal";
            this.Btn_YeniOgrenciKayitIptal.Size = new System.Drawing.Size(145, 38);
            this.Btn_YeniOgrenciKayitIptal.TabIndex = 44;
            this.Btn_YeniOgrenciKayitIptal.Text = "iptal/kapat";
            this.Btn_YeniOgrenciKayitIptal.Click += new System.EventHandler(this.Btn_YeniOgrenciKayitIptal_Click);
            // 
            // Btn_YeniOgrenciKaydet
            // 
            this.Btn_YeniOgrenciKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKaydet.ImageOptions.Image")));
            this.Btn_YeniOgrenciKaydet.Location = new System.Drawing.Point(127, 228);
            this.Btn_YeniOgrenciKaydet.Name = "Btn_YeniOgrenciKaydet";
            this.Btn_YeniOgrenciKaydet.Size = new System.Drawing.Size(145, 42);
            this.Btn_YeniOgrenciKaydet.TabIndex = 45;
            this.Btn_YeniOgrenciKaydet.Text = "kaydet";
            this.Btn_YeniOgrenciKaydet.Click += new System.EventHandler(this.Btn_YeniOgrenciKaydet_Click);
            // 
            // txt_okulEgitimYili
            // 
            this.txt_okulEgitimYili.Location = new System.Drawing.Point(127, 169);
            this.txt_okulEgitimYili.Name = "txt_okulEgitimYili";
            this.txt_okulEgitimYili.Size = new System.Drawing.Size(145, 22);
            this.txt_okulEgitimYili.TabIndex = 43;
            // 
            // FrmOkulTurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 419);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_YeniOgrenciKayitIptal);
            this.Controls.Add(this.Btn_YeniOgrenciKaydet);
            this.Controls.Add(this.txt_okulEgitimYili);
            this.Controls.Add(this.txt_okulTurAd);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOkulTurEkle";
            this.Text = "FrmOkulTurEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKayitIptal;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKaydet;
        private System.Windows.Forms.TextBox txt_okulTurAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_okulEgitimYili;
    }
}