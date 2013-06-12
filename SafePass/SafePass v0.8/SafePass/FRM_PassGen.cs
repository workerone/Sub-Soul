using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SafePass
{
    public partial class FRM_PassGen : Form
    {
        public FRM_PassGen()
        {
            InitializeComponent();
        }

        private void FRM_PassGen_Load(object sender, EventArgs e)
        {
            TXT_Password.Text = GenRandString(32);
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            TXT_Password.Text = GenRandString(32);
        }

        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TXT_Password.Text);
        }

        private string GenRandString(int iLength)
        {
            byte[] bArrBuff = new byte[iLength];
            RandomNumberGenerator.Create().GetBytes(bArrBuff);

            return System.Convert.ToBase64String(bArrBuff).Remove(iLength);
        }
    }
}
