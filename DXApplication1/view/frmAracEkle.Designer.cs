namespace DXApplication1
{
    partial class frmAracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracEkle));
            this.comboBox_okul1 = new System.Windows.Forms.ComboBox();
            this.txt_aracKoltukSayisi = new System.Windows.Forms.TextBox();
            this.txt_aracKiraTutar = new System.Windows.Forms.TextBox();
            this.txt_aracPlaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_sofor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_okul2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_okul3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_YeniOgrenciKayitIptal = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YeniOgrenciKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_aracBaslama = new System.Windows.Forms.DateTimePicker();
            this.txt_aracBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBox_okul1
            // 
            this.comboBox_okul1.FormattingEnabled = true;
            this.comboBox_okul1.ItemHeight = 16;
            this.comboBox_okul1.Items.AddRange(new object[] {
            "-"});
            this.comboBox_okul1.Location = new System.Drawing.Point(174, 164);
            this.comboBox_okul1.MaxDropDownItems = 20;
            this.comboBox_okul1.Name = "comboBox_okul1";
            this.comboBox_okul1.Size = new System.Drawing.Size(145, 24);
            this.comboBox_okul1.TabIndex = 5;
            this.comboBox_okul1.SelectedIndexChanged += new System.EventHandler(this.comboBox_okul1_SelectedIndexChanged);
            // 
            // txt_aracKoltukSayisi
            // 
            this.txt_aracKoltukSayisi.Location = new System.Drawing.Point(174, 98);
            this.txt_aracKoltukSayisi.MaxLength = 2;
            this.txt_aracKoltukSayisi.Name = "txt_aracKoltukSayisi";
            this.txt_aracKoltukSayisi.Size = new System.Drawing.Size(145, 22);
            this.txt_aracKoltukSayisi.TabIndex = 2;
            this.txt_aracKoltukSayisi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_kontrol_KeyUp);
            // 
            // txt_aracKiraTutar
            // 
            this.txt_aracKiraTutar.Location = new System.Drawing.Point(174, 266);
            this.txt_aracKiraTutar.Name = "txt_aracKiraTutar";
            this.txt_aracKiraTutar.Size = new System.Drawing.Size(145, 22);
            this.txt_aracKiraTutar.TabIndex = 9;
            this.txt_aracKiraTutar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_kontrol_KeyUp);
            // 
            // txt_aracPlaka
            // 
            this.txt_aracPlaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_aracPlaka.Location = new System.Drawing.Point(174, 66);
            this.txt_aracPlaka.MaxLength = 7;
            this.txt_aracPlaka.Name = "txt_aracPlaka";
            this.txt_aracPlaka.Size = new System.Drawing.Size(145, 22);
            this.txt_aracPlaka.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "okul";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "baslama tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "kira tutarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "koltuk sayisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "plaka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "soför";
            // 
            // comboBox_sofor
            // 
            this.comboBox_sofor.FormattingEnabled = true;
            this.comboBox_sofor.ItemHeight = 16;
            this.comboBox_sofor.Location = new System.Drawing.Point(174, 130);
            this.comboBox_sofor.Name = "comboBox_sofor";
            this.comboBox_sofor.Size = new System.Drawing.Size(145, 24);
            this.comboBox_sofor.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "okul 2";
            // 
            // comboBox_okul2
            // 
            this.comboBox_okul2.FormattingEnabled = true;
            this.comboBox_okul2.Location = new System.Drawing.Point(174, 198);
            this.comboBox_okul2.MaxDropDownItems = 20;
            this.comboBox_okul2.Name = "comboBox_okul2";
            this.comboBox_okul2.Size = new System.Drawing.Size(145, 24);
            this.comboBox_okul2.TabIndex = 7;
            this.comboBox_okul2.SelectedIndexChanged += new System.EventHandler(this.comboBox_okul2_SelectedIndexChanged);
            this.comboBox_okul2.Click += new System.EventHandler(this.comboBox_okul2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "okul 3";
            // 
            // comboBox_okul3
            // 
            this.comboBox_okul3.FormattingEnabled = true;
            this.comboBox_okul3.Location = new System.Drawing.Point(174, 232);
            this.comboBox_okul3.Name = "comboBox_okul3";
            this.comboBox_okul3.Size = new System.Drawing.Size(145, 24);
            this.comboBox_okul3.TabIndex = 8;
            this.comboBox_okul3.Click += new System.EventHandler(this.comboBox_okul3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "YENİ ARAÇ EKLEME";
            // 
            // Btn_YeniOgrenciKayitIptal
            // 
            this.Btn_YeniOgrenciKayitIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKayitIptal.ImageOptions.Image")));
            this.Btn_YeniOgrenciKayitIptal.Location = new System.Drawing.Point(530, 322);
            this.Btn_YeniOgrenciKayitIptal.Name = "Btn_YeniOgrenciKayitIptal";
            this.Btn_YeniOgrenciKayitIptal.Size = new System.Drawing.Size(145, 38);
            this.Btn_YeniOgrenciKayitIptal.TabIndex = 13;
            this.Btn_YeniOgrenciKayitIptal.Text = "iptal/kapat";
            this.Btn_YeniOgrenciKayitIptal.Click += new System.EventHandler(this.Btn_YeniOgrenciKayitIptal_Click);
            // 
            // Btn_YeniOgrenciKaydet
            // 
            this.Btn_YeniOgrenciKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_YeniOgrenciKaydet.ImageOptions.Image")));
            this.Btn_YeniOgrenciKaydet.Location = new System.Drawing.Point(530, 248);
            this.Btn_YeniOgrenciKaydet.Name = "Btn_YeniOgrenciKaydet";
            this.Btn_YeniOgrenciKaydet.Size = new System.Drawing.Size(145, 64);
            this.Btn_YeniOgrenciKaydet.TabIndex = 12;
            this.Btn_YeniOgrenciKaydet.Text = "kaydet";
            this.Btn_YeniOgrenciKaydet.Click += new System.EventHandler(this.Btn_YeniOgrenciKaydet_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(354, 165);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(109, 23);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "yeni okul";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(354, 132);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "yeni soför";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "bitis tarihi";
            // 
            // txt_aracBaslama
            // 
            this.txt_aracBaslama.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.txt_aracBaslama.CustomFormat = "yyyy-MM-dd";
            this.txt_aracBaslama.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_aracBaslama.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_aracBaslama.Location = new System.Drawing.Point(174, 298);
            this.txt_aracBaslama.Name = "txt_aracBaslama";
            this.txt_aracBaslama.Size = new System.Drawing.Size(145, 26);
            this.txt_aracBaslama.TabIndex = 10;
            this.txt_aracBaslama.Value = new System.DateTime(2018, 4, 17, 0, 0, 0, 0);
            // 
            // txt_aracBitisTarihi
            // 
            this.txt_aracBitisTarihi.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.txt_aracBitisTarihi.CustomFormat = "yyyy-MM-dd";
            this.txt_aracBitisTarihi.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_aracBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_aracBitisTarihi.Location = new System.Drawing.Point(174, 334);
            this.txt_aracBitisTarihi.Name = "txt_aracBitisTarihi";
            this.txt_aracBitisTarihi.Size = new System.Drawing.Size(145, 26);
            this.txt_aracBitisTarihi.TabIndex = 11;
            this.txt_aracBitisTarihi.Value = new System.DateTime(2018, 4, 17, 0, 0, 0, 0);
            // 
            // frmAracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 409);
            this.Controls.Add(this.txt_aracBitisTarihi);
            this.Controls.Add(this.txt_aracBaslama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_YeniOgrenciKayitIptal);
            this.Controls.Add(this.Btn_YeniOgrenciKaydet);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.comboBox_okul3);
            this.Controls.Add(this.comboBox_okul2);
            this.Controls.Add(this.comboBox_okul1);
            this.Controls.Add(this.comboBox_sofor);
            this.Controls.Add(this.txt_aracKoltukSayisi);
            this.Controls.Add(this.txt_aracKiraTutar);
            this.Controls.Add(this.txt_aracPlaka);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAracEkle";
            this.Text = "frmAracEkle";
            this.Load += new System.EventHandler(this.frmAracEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.ComboBox comboBox_okul1;
        private System.Windows.Forms.TextBox txt_aracKoltukSayisi;
        private System.Windows.Forms.TextBox txt_aracKiraTutar;
        private System.Windows.Forms.TextBox txt_aracPlaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sofor;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_okul2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_okul3;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKayitIptal;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniOgrenciKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txt_aracBaslama;
        private System.Windows.Forms.DateTimePicker txt_aracBitisTarihi;
    }
}