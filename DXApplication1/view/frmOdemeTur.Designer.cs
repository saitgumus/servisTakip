namespace DXApplication1.view
{
    partial class frmOdemeTur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeTur));
            this.label7 = new System.Windows.Forms.Label();
            this.txt_odemeTurAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_YeniOgrenciKayitIptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YeniOgrenciKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "YENİ ÖDEME TÜRÜ";
            // 
            // txt_odemeTurAd
            // 
            this.txt_odemeTurAd.Location = new System.Drawing.Point(151, 147);
            this.txt_odemeTurAd.Name = "txt_odemeTurAd";
            this.txt_odemeTurAd.Size = new System.Drawing.Size(127, 23);
            this.txt_odemeTurAd.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "ad";
            // 
            // Btn_YeniOgrenciKayitIptal
            // 
            this.Btn_YeniOgrenciKayitIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKayitIptal.ImageOptions.Image")));
            this.Btn_YeniOgrenciKayitIptal.Location = new System.Drawing.Point(151, 266);
            this.Btn_YeniOgrenciKayitIptal.Name = "Btn_YeniOgrenciKayitIptal";
            this.Btn_YeniOgrenciKayitIptal.Size = new System.Drawing.Size(127, 38);
            this.Btn_YeniOgrenciKayitIptal.TabIndex = 51;
            this.Btn_YeniOgrenciKayitIptal.Text = "iptal/kapat";
            this.Btn_YeniOgrenciKayitIptal.Click += new System.EventHandler(this.Btn_YeniOgrenciKayitIptal_Click);
            // 
            // Btn_YeniOgrenciKaydet
            // 
            this.Btn_YeniOgrenciKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKaydet.ImageOptions.Image")));
            this.Btn_YeniOgrenciKaydet.Location = new System.Drawing.Point(151, 206);
            this.Btn_YeniOgrenciKaydet.Name = "Btn_YeniOgrenciKaydet";
            this.Btn_YeniOgrenciKaydet.Size = new System.Drawing.Size(127, 42);
            this.Btn_YeniOgrenciKaydet.TabIndex = 52;
            this.Btn_YeniOgrenciKaydet.Text = "kaydet";
            this.Btn_YeniOgrenciKaydet.Click += new System.EventHandler(this.Btn_YeniOgrenciKaydet_Click);
            // 
            // frmOdemeTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 401);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_YeniOgrenciKayitIptal);
            this.Controls.Add(this.Btn_YeniOgrenciKaydet);
            this.Controls.Add(this.txt_odemeTurAd);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOdemeTur";
            this.Text = "frmOdemeTurEkle";
            this.Load += new System.EventHandler(this.frmOdemeTur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKayitIptal;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKaydet;
        private System.Windows.Forms.TextBox txt_odemeTurAd;
        private System.Windows.Forms.Label label2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}