namespace DXApplication1
{
    partial class FrmOkulEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOkulEkle));
            this.label7 = new System.Windows.Forms.Label();
            this.txt_okulAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_okulTur = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YeniOgrenciKayitIptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YeniOgrenciKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._il = new System.Windows.Forms.TextBox();
            this._ilce = new System.Windows.Forms.TextBox();
            this._posta = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this._sokak = new System.Windows.Forms.TextBox();
            this._cadde = new System.Windows.Forms.TextBox();
            this._mahalle = new System.Windows.Forms.TextBox();
            this.lblSokak = new System.Windows.Forms.Label();
            this.lblCadde = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "YENİ OKUL EKLE";
            // 
            // txt_okulAd
            // 
            this.txt_okulAd.Location = new System.Drawing.Point(138, 115);
            this.txt_okulAd.Name = "txt_okulAd";
            this.txt_okulAd.Size = new System.Drawing.Size(145, 22);
            this.txt_okulAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "ad";
            // 
            // comboBox_okulTur
            // 
            this.comboBox_okulTur.FormattingEnabled = true;
            this.comboBox_okulTur.Location = new System.Drawing.Point(138, 147);
            this.comboBox_okulTur.Name = "comboBox_okulTur";
            this.comboBox_okulTur.Size = new System.Drawing.Size(145, 24);
            this.comboBox_okulTur.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "okul türü";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(289, 148);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(109, 23);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "yeni tür";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Btn_YeniOgrenciKayitIptal
            // 
            this.Btn_YeniOgrenciKayitIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKayitIptal.ImageOptions.Image")));
            this.Btn_YeniOgrenciKayitIptal.Location = new System.Drawing.Point(138, 485);
            this.Btn_YeniOgrenciKayitIptal.Name = "Btn_YeniOgrenciKayitIptal";
            this.Btn_YeniOgrenciKayitIptal.Size = new System.Drawing.Size(145, 38);
            this.Btn_YeniOgrenciKayitIptal.TabIndex = 6;
            this.Btn_YeniOgrenciKayitIptal.Text = "iptal/kapat";
            this.Btn_YeniOgrenciKayitIptal.Click += new System.EventHandler(this.Btn_YeniOgrenciKayitIptal_Click);
            // 
            // Btn_YeniOgrenciKaydet
            // 
            this.Btn_YeniOgrenciKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKaydet.ImageOptions.Image")));
            this.Btn_YeniOgrenciKaydet.Location = new System.Drawing.Point(138, 433);
            this.Btn_YeniOgrenciKaydet.Name = "Btn_YeniOgrenciKaydet";
            this.Btn_YeniOgrenciKaydet.Size = new System.Drawing.Size(145, 42);
            this.Btn_YeniOgrenciKaydet.TabIndex = 5;
            this.Btn_YeniOgrenciKaydet.Text = "kaydet";
            this.Btn_YeniOgrenciKaydet.Click += new System.EventHandler(this.Btn_YeniOgrenciKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._il);
            this.groupBox1.Controls.Add(this._ilce);
            this.groupBox1.Controls.Add(this._posta);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this._sokak);
            this.groupBox1.Controls.Add(this._cadde);
            this.groupBox1.Controls.Add(this._mahalle);
            this.groupBox1.Controls.Add(this.lblSokak);
            this.groupBox1.Controls.Add(this.lblCadde);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(28, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 226);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "adres";
            // 
            // _il
            // 
            this._il.Location = new System.Drawing.Point(110, 174);
            this._il.Name = "_il";
            this._il.Size = new System.Drawing.Size(145, 22);
            this._il.TabIndex = 13;
            // 
            // _ilce
            // 
            this._ilce.Location = new System.Drawing.Point(110, 144);
            this._ilce.Name = "_ilce";
            this._ilce.Size = new System.Drawing.Size(145, 22);
            this._ilce.TabIndex = 12;
            // 
            // _posta
            // 
            this._posta.Location = new System.Drawing.Point(110, 114);
            this._posta.Name = "_posta";
            this._posta.Size = new System.Drawing.Size(145, 22);
            this._posta.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(90, 174);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 18);
            this.label21.TabIndex = 0;
            this.label21.Text = "il";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(74, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "ilçe";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "posta kodu";
            // 
            // _sokak
            // 
            this._sokak.Location = new System.Drawing.Point(110, 86);
            this._sokak.Name = "_sokak";
            this._sokak.Size = new System.Drawing.Size(145, 22);
            this._sokak.TabIndex = 8;
            // 
            // _cadde
            // 
            this._cadde.Location = new System.Drawing.Point(110, 56);
            this._cadde.Name = "_cadde";
            this._cadde.Size = new System.Drawing.Size(145, 22);
            this._cadde.TabIndex = 7;
            // 
            // _mahalle
            // 
            this._mahalle.Location = new System.Drawing.Point(110, 26);
            this._mahalle.Name = "_mahalle";
            this._mahalle.Size = new System.Drawing.Size(145, 22);
            this._mahalle.TabIndex = 6;
            // 
            // lblSokak
            // 
            this.lblSokak.AutoSize = true;
            this.lblSokak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSokak.Location = new System.Drawing.Point(55, 86);
            this.lblSokak.Name = "lblSokak";
            this.lblSokak.Size = new System.Drawing.Size(49, 18);
            this.lblSokak.TabIndex = 0;
            this.lblSokak.Text = "sokak";
            // 
            // lblCadde
            // 
            this.lblCadde.AutoSize = true;
            this.lblCadde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadde.Location = new System.Drawing.Point(56, 56);
            this.lblCadde.Name = "lblCadde";
            this.lblCadde.Size = new System.Drawing.Size(48, 18);
            this.lblCadde.TabIndex = 0;
            this.lblCadde.Text = "cadde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "mahalle";
            // 
            // FrmOkulEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.comboBox_okulTur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_YeniOgrenciKayitIptal);
            this.Controls.Add(this.Btn_YeniOgrenciKaydet);
            this.Controls.Add(this.txt_okulAd);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOkulEkle";
            this.Text = "FrmOkulEkle";
            this.Load += new System.EventHandler(this.FrmOkulEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKayitIptal;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKaydet;
        private System.Windows.Forms.TextBox txt_okulAd;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.ComboBox comboBox_okulTur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _il;
        private System.Windows.Forms.TextBox _ilce;
        private System.Windows.Forms.TextBox _posta;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox _sokak;
        private System.Windows.Forms.TextBox _cadde;
        private System.Windows.Forms.TextBox _mahalle;
        private System.Windows.Forms.Label lblSokak;
        private System.Windows.Forms.Label lblCadde;
        private System.Windows.Forms.Label label6;
    }
}