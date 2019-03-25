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
    public partial class ogrenciGuncelle : Form
    {
        public ogrenciGuncelle(string Id, string table)
        {
            id = Id;
            tablo = table;
            InitializeComponent();
        }


        string id;
        string tablo;
        veri veri = new veri();
        DataTable dt = new DataTable();





        private void ogrenciGuncelle_Load(object sender, EventArgs e)
        {
           

            dt = veri.tabloGetir(tablo+"  where  id = " + id);

            gridControl1.DataSource = dt;
           // winExplorerView1.PopulateColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri.ogrenciGuncelle(dt);
            MessageBox.Show("ok");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("öğe kalıcı olarak silinecek. Silmek istediğinize emin misiniz?",
                                "SİL!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    veri.ogeSil(tablo, id);
                }
            }
            catch
            {
                MessageBox.Show("başarısız");
            }



        }
    }
}
