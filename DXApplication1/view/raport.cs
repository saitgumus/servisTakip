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
    public partial class raport : Form
    {
     
        public raport()
        {
            InitializeComponent();
        }

        private void raport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
           
        }
        
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
