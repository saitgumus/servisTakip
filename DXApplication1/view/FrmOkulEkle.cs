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
    public partial class FrmOkulEkle : Form
    {
        public FrmOkulEkle()
        {
            InitializeComponent();
        }

        private void Btn_YeniOgrenciKayitIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmOkulTurEkle frm = new FrmOkulTurEkle();
            frm.Show();
        }

        veri veri = new veri();



        private void FrmOkulEkle_Load(object sender, EventArgs e)
        {
            DataTable dt = veri.tabloGetir("okul_turleri");

            comboBox_okulTur.DataSource = dt;
            comboBox_okulTur.DisplayMember = "Ad";
            comboBox_okulTur.ValueMember = "id";


        }

        private void Btn_YeniOgrenciKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_okulAd.Text))
                return;


            Dictionary<string, string> bilgiler = new Dictionary<string, string>();
            bilgiler.Add("@ad", txt_okulAd.Text);
            bilgiler.Add("@tur_id", comboBox_okulTur.SelectedValue.ToString());
            bilgiler.Add("@mahalle", _mahalle.Text);
            bilgiler.Add("@cadde", _cadde.Text);
            bilgiler.Add("@sokak", _sokak.Text);
            bilgiler.Add("@postaKodu", _posta.Text);
            bilgiler.Add("@ilce", _ilce.Text);
            bilgiler.Add("@il", _il.Text);

            veri.okulEkleProcedure(bilgiler);
            MessageBox.Show("kayıt tamamlandı");

            txt_okulAd.Text = "";
            foreach (Control tb in groupBox1.Controls)
            {
                if (tb is TextBox )
                {
                    tb.Text = "";
                }

            }

        }
    }
}
