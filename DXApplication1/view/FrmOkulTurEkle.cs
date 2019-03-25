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
    public partial class FrmOkulTurEkle : Form
    {
        public FrmOkulTurEkle()
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
            if (string.IsNullOrEmpty(txt_okulTurAd.Text) || string.IsNullOrEmpty(txt_okulEgitimYili.Text))
                return;

            string values =
              "('" + txt_okulTurAd.Text + "'," +
              "'" + txt_okulEgitimYili.Text + "')";

            veri.insert("okul_turleri", values);

            txt_okulTurAd.Text = "";
            txt_okulEgitimYili.Text = "";
        }
    }
}
