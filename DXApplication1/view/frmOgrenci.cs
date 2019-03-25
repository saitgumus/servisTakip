using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        

        veri veri = new veri();

        private void Btn_YeniOgrenciKayitIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmAracEkle frm = new frmAracEkle();
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmOkulEkle frm = new FrmOkulEkle();
            frm.Show();
        }

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            //select plaka,[doluluk oranı] as durum from aracListesi group by plaka,[doluluk oranı]
            //
           // select id, plaka, bos_koltuk from servis_Araclari where bos_koltuk > 0
          
            combo_okul.DataSource = veri.tabloGetir("okul");
            combo_okul.DisplayMember = "ad";
            combo_okul.ValueMember = "id";
            
        }



        private void Btn_YeniOgrenciKaydet_Click(object sender, EventArgs e)
        {


            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && (string.IsNullOrEmpty(tb.Text)) && (tb.Name.Trim() != "txt_ogrenciBitis") && (tb.Name.Trim() != "txt_ogrenciBaslama"))
                {
                    MessageBox.Show("eksik veya boş alan var","eksik alan var",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

            }
            foreach (Control tb in groupBox1.Controls)
            {
                if (tb is TextBox && (string.IsNullOrEmpty(tb.Text)))
                {
                    MessageBox.Show("adres alanında boş alan bırakmamalısın..","eksik alan var",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

            }



            Dictionary<string, string> bilgiler = new Dictionary<string, string>();
            bilgiler.Add("@ad", txt_ogrenciAd.Text);
            bilgiler.Add("@soyad", txt_ogrenciSoyad.Text);
            bilgiler.Add("@cinsiyet", txt_ogrenciCins.Text);
            bilgiler.Add("@veli", txt_ogrenciVeliAd.Text);
            bilgiler.Add("@tel", txt_ogrenciTel.Text);
            bilgiler.Add("@servis_id", combo_servis.SelectedValue.ToString());//int
            bilgiler.Add("@okul_id", combo_okul.SelectedValue.ToString());
            bilgiler.Add("@sinif", txt_ogrenciSinif.Text);
            bilgiler.Add("@servisUcret", txt_ogrenciUcret.Text);
            bilgiler.Add("@taksitSecenek", txt_ogrenciTaksit.SelectedValue.ToString());// int
            bilgiler.Add("@taksitMiktar", secilenUcret.ToString());
            bilgiler.Add("@serviseBaslamaTarihi", txt_ogrenciBaslama.Text);
            bilgiler.Add("@servisBitisTarihi", txt_ogrenciBitis.Text);
            
            //adres Bilgileri
            bilgiler.Add("@mahalle", _mahalle.Text);
            bilgiler.Add("@cadde", _cadde.Text);
            bilgiler.Add("@sokak", _sokak.Text);
            bilgiler.Add("@site", _apartman.Text);
            bilgiler.Add("@kat", _katDaire.Text);
            bilgiler.Add("@postaKodu", _posta.Text);
            bilgiler.Add("@ilce", _ilce.Text);
            bilgiler.Add("@il", _il.Text);

            veri.ogrenciEkleProcedure(bilgiler);


            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Text = "";
                }

            }

        }



            //sadece numerik deger alacak textboxlar için
        private void txt_ogrenciSinif_KeyUp(object sender, KeyEventArgs e)
        {
            char s = Convert.ToChar(e.KeyData);
            TextBox tb = (TextBox)sender;
            if (!Char.IsNumber(s))
                tb.Clear();
           
         }


        //servis ücreti girildikten sonra
        double servisUcreti = 0;
        double secilenUcret = 0;
        int tarihFark = 0;//Ogrenci baslama ve bitiş arası gün farkı
       
        private void txt_ogrenciUcret_Leave(object sender, EventArgs e)
        {
            servisUcreti = Convert.ToInt32(txt_ogrenciUcret.Text);

            if (servisUcreti > 0)
            {
                int tarihFarkAy = 0; // ogrenci baslama ve bitiş arası ay farkı

            if (tarihFark % 30 > 5)//eğer ay farkında artan gün sayısı 5 i geçerse bir ay daha ekle
                tarihFarkAy = (tarihFark / 30) + 1;
            else
                tarihFarkAy /= 30;
            

            Dictionary<int, string> taksitSozluk = new Dictionary<int, string>();
            taksitSozluk.Add(1, "peşin("+servisUcreti.ToString()+"/ )");

            
            if (servisUcreti >= 100 && servisUcreti <= 500)
            {   
                taksitSozluk.Add(2,"2 taksit("+ Math.Round((servisUcreti / 2),2).ToString()+"/ay)");
                if (!taksitSozluk.Keys.Contains(tarihFarkAy))
                    taksitSozluk.Add(tarihFarkAy, " (" + tarihFarkAy + " taksit " + Math.Round((servisUcreti / tarihFarkAy), 2) + " /ay)");
            }
            else if(servisUcreti > 500 && servisUcreti <= 1000)
            {
                taksitSozluk.Add(2, "2 taksit(" + Math.Round((servisUcreti / 2)).ToString() + "/ay)");
                taksitSozluk.Add(4, "4 taksit(" + Math.Round((servisUcreti / 4)).ToString() + "/ay)");
                taksitSozluk.Add(6, "6 taksit(" + Math.Round((servisUcreti / 6)).ToString() + "/ay)");
                if (!taksitSozluk.Keys.Contains(tarihFarkAy))
                    taksitSozluk.Add(tarihFarkAy, " (" + tarihFarkAy + " taksit " + Math.Round((servisUcreti / tarihFarkAy), 2) + " /ay)");
            }
            else if(servisUcreti > 1000)
            {
                taksitSozluk.Add(2, "2 taksit(" + Math.Round((servisUcreti / 2)).ToString() + "/ay)");
                taksitSozluk.Add(4, "4 taksit(" + Math.Round((servisUcreti / 4)).ToString() + "/ay)");
                taksitSozluk.Add(6, "6 taksit(" + Math.Round((servisUcreti / 6)).ToString() + "/ay)");
                taksitSozluk.Add(9, "9 taksit(" + Math.Round((servisUcreti / 9)).ToString() + "/ay)");
                if (!taksitSozluk.Keys.Contains(tarihFarkAy))
                    taksitSozluk.Add(tarihFarkAy, " (" + tarihFarkAy + " taksit " + Math.Round((servisUcreti / tarihFarkAy),2) + " /ay)");
            }
            

            txt_ogrenciTaksit.DataSource = new BindingSource(taksitSozluk, null);
            txt_ogrenciTaksit.DisplayMember = "Value";
            txt_ogrenciTaksit.ValueMember = "Key";



            }
            
        }

        private void txt_ogrenciBitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateBasla = Convert.ToDateTime(txt_ogrenciBaslama.Text) ;
            DateTime dateBit = Convert.ToDateTime(txt_ogrenciBitis.Text);
            TimeSpan sonuc = dateBit - dateBasla;
            tarihFark = Convert.ToInt32(sonuc.TotalDays);
        }


        //taksit seçeneği değiştiğinde
        private void txt_ogrenciTaksit_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (txt_ogrenciTaksit.SelectedValue.ToString().Length < 4)
            {
                int chr = txt_ogrenciTaksit.SelectedItem.ToString().IndexOf('(');
                int chr2 = txt_ogrenciTaksit.SelectedItem.ToString().IndexOf('/');
                string selected = txt_ogrenciTaksit.SelectedItem.ToString().Substring(chr+1, (chr2 - chr)-1);

                secilenUcret = Convert.ToInt32(selected);
               
               
            }
        }

        //okul seçimi yapılınca ilgili servis araclarının listelenmesi için
        private void combo_okul_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = combo_okul.SelectedValue.ToString();

            if (id.Length < 5)
            {
                combo_servis.DataSource = veri.tabloGetir(" servis_Araclari where bos_koltuk >= 0"+
                                                     "   and "+
                                                     " (  okul_id = "+id+" or okul_id2 = "+id+" or okul_id3 = "+id+" ) ");

            combo_servis.DisplayMember = "plaka";
            combo_servis.ValueMember = "id";

            }
          

        }
    }
}
