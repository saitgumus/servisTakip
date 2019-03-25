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
    public partial class FrmSoforEkle : Form
    {
        public FrmSoforEkle()
        {
            InitializeComponent();
        }


        veri veri = new veri();


        private void Btn_YeniOgrenciKayitIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_YeniOgrenciKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_soforAd.Text) || string.IsNullOrEmpty(txt_soforSoyad.Text) || string.IsNullOrEmpty(txt_soforMaas.Text))
                return;

            string values =
            "('" + txt_soforAd.Text + "'," +
            "'" + txt_soforSoyad.Text + "'," +
            "'" + txt_soforMaas.Text + "')";


           veri.insert("Soforler", values);

            txt_soforAd.Text = "";
            txt_soforSoyad.Text = "";
            txt_soforMaas.Text = "";
        }


        //sadece sayı yazılacak textboxlar için 
        private void numeric_kontrol_KeyUp(object sender, KeyEventArgs e)
        {
            char s = Convert.ToChar(e.KeyData);
            TextBox tb = (TextBox)sender;
            if (!Char.IsNumber(s))
                tb.Clear();
        }
    }
}
