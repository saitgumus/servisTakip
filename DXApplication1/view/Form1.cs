using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        //değişkenler
        raporlar.tahsilatBilgi tahsilatbilgi = new raporlar.tahsilatBilgi();//tahsilat & makbuz yazdırma işlemleri için tahsilat yapılan öğrenci bilgilerini saklar. 


        //fonksiyonlar
        veri veri = new veri();

        private void tahsilatYenile()
        {
            grid_tahsilat.DataSource = veri.tabloGetir("tahsilatListesi");
        }


        //form LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            string dosya = @"D:\adsiz.rtf";
            if(File.Exists(dosya) )
            richTextBox1.LoadFile(dosya);
            else
            {
                FileStream fs = File.Create(dosya);
                fs.Close();
                richTextBox1.LoadFile(dosya);
            }

            

            comboBox_odemeTur.DataSource = veri.tabloGetir("odeme_turleri");
            comboBox_odemeTur.DisplayMember = "tur_ad";
            comboBox_odemeTur.ValueMember = "id";

            
            

            chartControl1.Series["gelir"].DataSource = veri.tabloGetir("gelirAnaliz");
            chartControl1.Series["gelir"].ArgumentDataMember = "ay";
            chartControl1.Series["gelir"].ValueDataMembers.AddRange(new string[] {"toplamGelir" }) ;

            chartControl1.Series["gider"].DataSource = veri.tabloGetir("giderAnaliz");
            chartControl1.Series["gider"].ArgumentDataMember = "ay";
            chartControl1.Series["gider"].ValueDataMembers.AddRange(new string[] { "toplamGider" });


            chartControl2.Series["okul"].DataSource = veri.tabloGetir("okulAnaliz");
            chartControl2.Series["okul"].ArgumentDataMember = "okulAd";
            chartControl2.Series["okul"].ValueDataMembers.AddRange(new string[] { "toplamOgrenci" });

            tahsilatYenile();
        }


        //form KAPATILIRKEN notları otomatik kaydetmek için
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            richTextBox1.SaveFile(@"D:\adsiz.rtf");


        }





        //TANIMLAR SAYFASI

        private void Btn_ogrenciEkle_Click(object sender, EventArgs e)
        {
            frmOgrenci frmOgrenci = new frmOgrenci();
            frmOgrenci.Show();
        }

        private void Btn_aracEkle_Click(object sender, EventArgs e)
        {
            frmAracEkle frm = new frmAracEkle();
            frm.Show();
        }

        private void button_soforEkle_Click(object sender, EventArgs e)
        {
            FrmSoforEkle frm = new FrmSoforEkle();
            frm.Show();
        }

        private void button_okulEkle_Click(object sender, EventArgs e)
        {
            FrmOkulEkle frm = new FrmOkulEkle();
            frm.Show();
        }



      

        //  LİSTELER SAYFASI
         //-öğrenci listesi butonu
        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
            dataGrid_listeler.DataSource = veri.tabloGetir("ogrenciListesi");
            gridView1.PopulateColumns();
            seciliListeAd = "ogrenciler";
        }

        //-şoför listesi butonu
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            dataGrid_listeler.DataSource = veri.tabloGetir("SoforListesi");
            gridView1.PopulateColumns();
            seciliListeAd = "Soforler";
        }


        //-araç listesi butonu

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            dataGrid_listeler.DataSource = veri.tabloGetir("aracListesi");
            gridView1.PopulateColumns();
            seciliListeAd = "servis_Araclari";

        }

        //-okul listesi butonu

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            dataGrid_listeler.DataSource = veri.tabloGetir("okulListesi");
            gridView1.PopulateColumns();
            seciliListeAd = "okul";
        }

       




        //sadece sayı yazılacak textboxlar için kontrol fonksiyonu
        private void numeric_kontrol_KeyUp(object sender, KeyEventArgs e)
        {
            char s = Convert.ToChar(e.KeyData);
            TextBox tb = (TextBox)sender;
            if (!Char.IsNumber(s))
                tb.Clear();
        }



   







        //TAHSİLAT TAB PAGE'İ
        raporlar.tahsilatBilgi bilgi = new raporlar.tahsilatBilgi();
        private void button_tahsilatYap_Click(object sender, EventArgs e)
        {
          
            foreach (Control tb in groupBox_tahsilat.Controls)
            {
                if (tb is TextBox && (string.IsNullOrEmpty(tb.Text)))
                {
                    MessageBox.Show("eksik veya boş alan var");
                    return;
                }

            }



            Dictionary<string, string> bilgiler = new Dictionary<string, string>();
            bilgiler.Add("@id", txt_tahsilatOgrenciId.Text);
            bilgiler.Add("@tarih", dateEdit_tahsilatTarih.Text);
            bilgiler.Add("@miktar", txt_tahsilatMiktar.Text);

            veri.tahsilatProcedure(bilgiler);
            
             bilgi = veri.viewMakbuz(txt_tahsilatOgrenciId.Text,txt_tahsilatMiktar.Text, dateEdit_tahsilatTarih.Text);

            MessageBox.Show("tahsilat işlendi.");
            
          

            tahsilatYenile();
        }











        //makbuz yazdırma bölümü

        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (bilgi.OgrenciAd != null)
            {



                Font baslik = new Font("verdana", 14, FontStyle.Bold);
                Font text = new Font("verdana", 12);
                SolidBrush firca = new SolidBrush(Color.Black);

                StringFormat sformat = new StringFormat();
                sformat.Alignment = StringAlignment.Near;

                e.Graphics.DrawString("TAHSİLAT MAKBUZU", baslik, firca, 300, 50);
                e.Graphics.DrawString("id ", text, firca, 50, 100);
                e.Graphics.DrawString("ad  soyad", text, firca, 100, 100);
                e.Graphics.DrawString("miktar", text, firca, 320, 100);
                e.Graphics.DrawString("tarih", text, firca, 420, 100);
                e.Graphics.DrawString("kalan borc  ", text, firca, 600, 100);


                e.Graphics.DrawString("___________________________________________________________________", text, firca, 50, 120);

                e.Graphics.DrawString(bilgi.OgrenciId.ToString(), text, firca, 50, 160);
                e.Graphics.DrawString(bilgi.OgrenciAd + "  " + bilgi.OgrenciSoyAd, text, firca, 100, 160);
                e.Graphics.DrawString(bilgi.Miktar.ToString(), text, firca, 320, 160);
                e.Graphics.DrawString(bilgi.Tarih.ToString(), text, firca, 420, 160);
                e.Graphics.DrawString(bilgi.KalanBorc.ToString(), text, firca, 600, 160);
            }

        }

        private void button_tahsilatMakbuz_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.ShowDialog();

        }











        //ODEMELER PAGE'İ


        private void simpleButton1_Click(object sender, EventArgs e)//yeni ödeme türü eklemek için
        {
            view.frmOdemeTur frm = new view.frmOdemeTur();
            frm.ShowDialog();
        }

        private void grid_odemeler_SelectionChanged(object sender, EventArgs e)
        {
           
        
        }
        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
           
        }



        private void ımageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_odemeTur.SelectedItem.ToString())
            {
                case "şoför maaş":
                    label_odemeDegiskenId.Text = "şoför id";
                    if (!txt_odemeId.Enabled) txt_odemeId.Enabled = true;
                    break;
                case "araç kira":
                    label_odemeDegiskenId.Text = "plaka";
                    if (!txt_odemeId.Enabled) txt_odemeId.Enabled = true;
                    break;
                default:
                    label_odemeDegiskenId.Text = "";
                    txt_odemeId.Enabled = false;
                    break;
            }



        }




        //odeme tür combobox değişim olayı
        private void comboBox_odemeTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_odemeTur.SelectedIndex > 0 || comboBox_odemeTur.Text.Trim() == "soforMaas")
            {
                string deger = comboBox_odemeTur.Text;

                if (deger.Trim() == "soforMaas")
                {
                    txt_odemeId.Enabled = true;
                    deger = "soforListesi";
                    label_odemeDegiskenId.Text = "sofor id";
                }
                else if (deger.Trim() == "aracKira")
                {

                    txt_odemeId.Enabled = true;
                    deger = "aracListesi";
                    label_odemeDegiskenId.Text = "arac id";
                }
                else
                {
                    deger = "giderListesi";
                    label_odemeDegiskenId.Text = "";
                    txt_odemeId.Enabled = false;
                }


                grid_odemeler.DataSource = veri.tabloGetir(deger);
                gridView3.PopulateColumns();
            }
        }



        //odeme yap butonu
        private void btn_odemelerTamamla_Click(object sender, EventArgs e)
        {



            foreach (Control tb in groupBox_odemeler.Controls)
            {
                if (tb is TextBox && (string.IsNullOrEmpty(tb.Text)) && (tb.Name.Trim() != "txt_giderAciklama"))
                {
                    MessageBox.Show("eksik veya boş alan var");
                    return;
                }

            }


            string tablo = comboBox_odemeTur.Text;
            string deger = "";

            if (tablo.Trim() == "soforMaas")
            {
                tablo = "sofor_odemeleri";
                deger = "(" +
              txt_odemeId.Text + ",'" +
              datetime_giderTarih.Text + "'," +
              txt_odemeMiktar.Text + ", '" +
              txt_giderAciklama.Text + "') ";

            }
            else if (tablo.Trim() == "aracKira")
            {
                tablo = "servisAracOdemeleri";
                deger = "(" +
           txt_odemeId.Text + ",'" +
           datetime_giderTarih.Text + "'," +
           txt_odemeMiktar.Text + " ) ";
            }
            else
            {
                tablo = "giderler";
                deger = "(" +
            txt_odemeId.Text + ",'" +
            txt_odemeMiktar.Text + ", '" +
            datetime_giderTarih.Text + "'," +
            txt_giderAciklama.Text + "') ";
            }



            veri.insert(tablo, deger);
            MessageBox.Show("odeme tamamlandı.");

        }













        //listeler gridi çift tıklama fonksiyonu
        string seciliListeAd = "ogrenciler";
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString();
            view.ogrenciGuncelle frm = new view.ogrenciGuncelle(id, seciliListeAd);
            frm.Show();

        }

     





      
    }
}
