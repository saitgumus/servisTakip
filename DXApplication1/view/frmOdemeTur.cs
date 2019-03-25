using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.view
{
    public partial class frmOdemeTur : DevExpress.XtraEditors.XtraForm
    {
        public frmOdemeTur()
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
            if (string.IsNullOrEmpty(txt_odemeTurAd.Text))
                return;

            veri.insert("odeme_turleri", txt_odemeTurAd.Text);

            MessageBox.Show(txt_odemeTurAd.Text + "adında odeme türü oluştu");
            this.Close();
        }

        private void frmOdemeTur_Load(object sender, EventArgs e)
        {

        }
    }
}
