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
    public partial class FRM_Group : Form
    {
        public int iIDGroup = -1;

        public FRM_Group()
        {
            InitializeComponent();
        }

        private void FRM_NuevoGrupo_Load(object sender, EventArgs e)
        {
            if (iIDGroup > -1)
            {
                TXT_Grupo.Text = CLS_DataManager.Instance.getListGroup.ElementAt(iIDGroup).aNombre;
                iIDGroup = int.Parse(CLS_DataManager.Instance.getListGroup.ElementAt(iIDGroup).aID);
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (TXT_Grupo.Text.Equals(""))
            {
                MessageBox.Show("Hace falta indicar el nombre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (CLS_DataManager.Instance.isGroupExists(TXT_Grupo.Text))
                {
                    MessageBox.Show("El nombre de grupo ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (iIDGroup == -1)
                    {
                        CLS_DataManager.Instance.addGroup(TXT_Grupo.Text);
                    }
                    else
                    {
                        CLS_DataManager.Instance.updateGroup(TXT_Grupo.Text, iIDGroup.ToString());
                    }

                    CLS_DataManager.Instance.loadGroups();
                    CLS_DataManager.Instance.loadData();

                    this.Close();
                }
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
