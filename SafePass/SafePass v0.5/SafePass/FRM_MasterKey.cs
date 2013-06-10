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
    public partial class FRM_MasterKey : Form
    {
        public FRM_MasterKey()
        {
            InitializeComponent();
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (TXT_ClaveActual.Text.Equals("") || TXT_ClaveNueva.Text.Equals(""))
            {
                MessageBox.Show(this, "Hace falta rellenar los campos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Si la clave actual es valida
            if (CLS_Auth.Instance.isValidKey(TXT_ClaveActual.Text))
            {
                CLS_Globales.tSecurity.setPassword(TXT_ClaveNueva.Text);
                CLS_Auth.Instance.setMasterKey();
                CLS_DataManager.Instance.updateAllData();
                CLS_DataManager.Instance.loadData();
            }
            else
            {
                MessageBox.Show(this, "La contraseña introducida no es valida!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Close();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
