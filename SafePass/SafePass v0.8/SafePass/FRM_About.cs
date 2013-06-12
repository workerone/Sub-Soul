using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class FRM_About : Form
    {
        public FRM_About()
        {
            InitializeComponent();
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
