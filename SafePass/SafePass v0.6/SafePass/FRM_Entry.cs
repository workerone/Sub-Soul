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
    public partial class FRM_Entry : Form
    {
        public int iIDEntry = -1;
        private CLS_Data tData;

        public FRM_Entry()
        {
            InitializeComponent();
        }

        private void FRM_NuevaEntrada_Load(object sender, EventArgs e)
        {
            cargarGrupos();

            if (this.iIDEntry > -1)
            {
                tData = CLS_DataManager.Instance.getDataByID(iIDEntry.ToString());

                TXT_Titulo.Text = tData.aTitulo;
                TXT_Usuario.Text = tData.aUser;
                TXT_Pass.Text = tData.aPassword;
                TXT_URL.Text = tData.aURL;
                TXT_Detalles.Text = tData.aDetalle;
                CMB_Grupos.Text = CLS_DataManager.Instance.getGroupNameByID(tData.aIDGrupo);
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (!(CMB_Grupos.SelectedIndex > -1))
            {
                MessageBox.Show("Hace falta seleccionar el grupo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (TXT_Titulo.Text.Equals(""))
                {
                    MessageBox.Show("Hace falta indicar el titulo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    String sIDGrupo = CLS_DataManager.Instance.getListGroup.ElementAt(CMB_Grupos.SelectedIndex).aID;

                    if (this.iIDEntry > -1)
                    {
                        CLS_DataManager.Instance.updateData(tData.aID , TXT_Titulo.Text, TXT_Usuario.Text, TXT_Pass.Text, TXT_URL.Text, TXT_Detalles.Text, sIDGrupo);
                    }
                    else
                    {
                        CLS_DataManager.Instance.addData(TXT_Titulo.Text, TXT_Usuario.Text, TXT_Pass.Text, TXT_URL.Text, TXT_Detalles.Text, sIDGrupo);
                    }

                    CLS_DataManager.Instance.loadData();
                    ((FRM_Main)this.Owner).TRV_Lista_NodeMouseClick(sender);

                    this.Close();
                }
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarGrupos()
        {
            for (int i = 0; i < CLS_DataManager.Instance.getListGroup.Count; i++)
            {
                CMB_Grupos.Items.Add(CLS_DataManager.Instance.getListGroup.ElementAt(i).aNombre);
            }
        }
    }
}
