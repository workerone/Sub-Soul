﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SafePass
{
    public partial class FRM_Auth : Form
    {
        public FRM_Auth()
        {
            InitializeComponent();
        }

        private void TXT_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BTN_Aceptar_Click(sender, e);
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (TXT_Pass.Text.Equals(""))
            {
                MessageBox.Show(this, "Hace falta indicar la contraseña!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Seteamos la contraseña
            CLS_Globals.tSecurity.setPassword(TXT_Pass.Text);
            // Inicializamos
            CLS_Auth.Instance.initialize(CLS_Globals.tDBManager.getDatabase, CLS_Globals.tSecurity);

            // Comprobamos si la clave ya existe
            if (!CLS_Auth.Instance.isKeyExists())
            {
                CLS_Auth.Instance.setMasterKey();
            }
            else
            {   // Si existe, entonces comprobamos si es valida
                if (!CLS_Auth.Instance.isValidKey())
                {
                    MessageBox.Show(this, "La contraseña es incorrecta!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // Concedemos el acceso a la información
            CLS_Auth.Instance.IsAccessGranted = true;
            // Inicializamos
            CLS_DataManager.Instance.initialize
            (
                CLS_Globals.tDBManager.getDatabase,
                CLS_Globals.tSecurity,
                Path.GetFileName(CLS_Globals.tDBManager.getDatabase.aFilePath)
            );

            // Pasamos los componentes TreeView y StatusStrip
            CLS_DataManager.Instance.setProperties(((FRM_Main)this.Owner).aTreeview, ((FRM_Main)this.Owner).aStatusStrup);
            // Cargamos los grupos y la información
            CLS_DataManager.Instance.loadGroups();
            CLS_DataManager.Instance.loadData();

            this.Close();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
