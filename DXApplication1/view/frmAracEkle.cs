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
    public partial class frmAracEkle : Form
    {
        public frmAracEkle()
        {
            InitializeComponent();
        }
        


        veri veri = new veri();

        private void Btn_YeniOgrenciKayitIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmSoforEkle frm = new FrmSoforEkle();
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmOkulEkle frm = new FrmOkulEkle();
            frm.Show();
        }


        DataTable dt;
        private void frmAracEkle_Load(object sender, EventArgs e)
        {
            dt = veri.tabloGetir("soforler");

            comboBox_sofor.DataSource = dt;
            comboBox_sofor.DisplayMember = "Ad";
            comboBox_sofor.ValueMember = "id";

            
            dt = veri.tabloGetir("okul");
            comboBox_okul1.DataSource = dt;
            comboBox_okul1.DisplayMember = "ad";
            comboBox_okul1.ValueMember = "id";

            DateTime date = DateTime.Today;
            txt_aracBaslama.Value = date;
            txt_aracBitisTarihi.Value = date;
        }

        private void Btn_YeniOgrenciKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && (string.IsNullOrEmpty(tb.Text)))
                {
                    MessageBox.Show("eksik veya boş alan var");
                    return;
                }

            }


         
            Dictionary<string, string> bilgiler = new Dictionary<string, string>();
            bilgiler.Add("@plaka", txt_aracPlaka.Text);
            bilgiler.Add("@koltukSayisi", txt_aracKoltukSayisi.Text);
            bilgiler.Add("@sofor_id", comboBox_sofor.SelectedValue.ToString());
            bilgiler.Add("@okul_id", comboBox_okul1.SelectedValue.ToString());
            if (comboBox_okul2.Items.Count > 0)
                bilgiler.Add("@okul_id2", comboBox_okul2.SelectedValue.ToString());
            if (comboBox_okul3.Items.Count > 0)
                bilgiler.Add("@okul_id3", comboBox_okul3.SelectedValue.ToString());
            bilgiler.Add("@kira", txt_aracKiraTutar.Text);
            bilgiler.Add("@baslama", txt_aracBaslama.Text);
            bilgiler.Add("@bitis", txt_aracBitisTarihi.Text);



           
            veri.aracEkleProcedure(bilgiler);

            MessageBox.Show("kayit eklendi");


            txt_aracPlaka.Text = "";
            txt_aracKoltukSayisi.Text = "";
            txt_aracKiraTutar.Text = "";
            txt_aracBaslama.Text = "";
        }

        //sadece sayı yazılacak textboxlar için 
        private void numeric_kontrol_KeyUp(object sender, KeyEventArgs e)
        {
            char s = Convert.ToChar(e.KeyData);
            TextBox tb = (TextBox)sender;
            if (!Char.IsNumber(s))
                tb.Clear();
        }

        private void hataVer(string mesaj)
        {
            MessageBox.Show(mesaj);
        }


        private void comboBox_okul1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox_okul2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox_okul2_Click(object sender, EventArgs e)
        {
            if (comboBox_okul1.SelectedValue.ToString().Length < 4)
            {
                dt = veri.tabloGetir("okul where id != " + comboBox_okul1.SelectedValue);

                comboBox_okul2.DataSource = dt;
                comboBox_okul2.DisplayMember = "ad";
                comboBox_okul2.ValueMember = "id";

            }
        }

        private void comboBox_okul3_Click(object sender, EventArgs e)
        {
            if (comboBox_okul2.SelectedValue.ToString().Length < 4)
            {
                dt = veri.tabloGetir("okul where id != " + comboBox_okul1.SelectedValue + " and id != " + comboBox_okul2.SelectedValue);

                comboBox_okul3.DataSource = dt;
                comboBox_okul3.DisplayMember = "ad";
                comboBox_okul3.ValueMember = "id";
            }
        }
    }
}
