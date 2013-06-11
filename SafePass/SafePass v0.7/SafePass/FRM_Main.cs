using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace SafePass
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            // Aplicamos el tamaño de la ventana
            this.Size = new Size(800, 460);
            // Instanciamos los objetos
            CLS_Globals.tDBManager = new CLS_DBManager();
            CLS_Globals.tSecurity = new CLS_Security();
        }

        private void TS_NuevaDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog tSaveFileDialog = new SaveFileDialog();

            tSaveFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            tSaveFileDialog.Filter = "sqlite files (*.sqlite)|*.sqlite";
            tSaveFileDialog.FilterIndex = 2;
            tSaveFileDialog.RestoreDirectory = true;

            if (tSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TRV_Lista.Nodes.Clear();

                CLS_Globals.tDBManager.initialize(tSaveFileDialog.FileName);
                CLS_Globals.tDBManager.newDatabase();
                CLS_Globals.tDBManager.loadDatabase();

                if (!CLS_Globals.tDBManager.isValidDatabase())
                {
                    MessageBox.Show(this, "La base de datos no es valida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                FRM_Auth tForm = new FRM_Auth();
                tForm.Owner = this;
                tForm.ShowDialog();
            }
        }

        private void TS_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog tOpenFileDialog = new OpenFileDialog();

            tOpenFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            tOpenFileDialog.Filter = "sqlite files (*.sqlite)|*.sqlite";
            tOpenFileDialog.FilterIndex = 2;
            tOpenFileDialog.RestoreDirectory = true;

            if (tOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TRV_Lista.Nodes.Clear();

                    CLS_Globals.tDBManager.initialize(tOpenFileDialog.FileName);
                    CLS_Globals.tDBManager.loadDatabase();

                    if (!CLS_Globals.tDBManager.isValidDatabase())
                    {
                        MessageBox.Show(this, "La base de datos no es valida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    FRM_Auth tForm = new FRM_Auth();
                    tForm.Owner = this;
                    tForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void TS_Refrescar_Click(object sender, EventArgs e)
        {
            if (CLS_Globals.tDBManager != null)
            {
                if (CLS_Auth.Instance.IsAccessGranted)
                {
                    if (CLS_Auth.Instance.isValidKey())
                    {
                        CLS_DataManager.Instance.loadGroups();
                        CLS_DataManager.Instance.loadData();
                    }
                }
            }
        }

        private void TS_NuevaEntrada_Click(object sender, EventArgs e)
        {
            if (CLS_Globals.tDBManager != null)
            {
                if (CLS_Auth.Instance.IsAccessGranted)
                {
                    if (CLS_Auth.Instance.isValidKey())
                    {
                        FRM_Entry tForm = new FRM_Entry();
                        tForm.Owner = this;
                        tForm.ShowDialog();
                    }
                }
            }
        }

        private void TRV_Lista_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e != null)
            {
                TRV_Lista.SelectedNode = e.Node;
            }

            List<CLS_Data> tListaDatos = CLS_DataManager.Instance.getListData;

            if (TRV_Lista.SelectedNode != null)
            {
                if (TRV_Lista.SelectedNode.Level > 0)
                {
                    LSV_Data.Items.Clear();

                    String sIDGrupo = CLS_DataManager.Instance.getListGroup.ElementAt(TRV_Lista.SelectedNode.Index).aID;

                    for (int i = 0; i < tListaDatos.Count; i++)
                    {
                        if (tListaDatos.ElementAt(i).aIDGrupo.Equals(sIDGrupo))
                        {
                            ListViewItem tItem = new ListViewItem();

                            tItem.Tag = tListaDatos.ElementAt(i).aID;
                            tItem.Text = tListaDatos.ElementAt(i).aTitulo;
                            tItem.SubItems.Add(tListaDatos.ElementAt(i).aUser);
                            tItem.SubItems.Add(tListaDatos.ElementAt(i).aPassword);
                            tItem.SubItems.Add(tListaDatos.ElementAt(i).aURL);
                            tItem.SubItems.Add(tListaDatos.ElementAt(i).aDetalle);

                            LSV_Data.Items.Add(tItem);
                        }
                    }
                }

                if (e != null)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        switch (TRV_Lista.SelectedNode.Level)
                        {
                            case 0:
                                MN_Grupos.Items[0].Enabled = true;
                                MN_Grupos.Items[1].Enabled = false;
                                MN_Grupos.Items[2].Enabled = false;
                                MN_Grupos.Show(TRV_Lista, new Point(e.X, e.Y));
                                break;

                            case 1:
                                if (TRV_Lista.SelectedNode.Index > 5)
                                {
                                    MN_Grupos.Items[0].Enabled = false;
                                    MN_Grupos.Items[1].Enabled = true;
                                    MN_Grupos.Items[2].Enabled = true;
                                    MN_Grupos.Show(TRV_Lista, new Point(e.X, e.Y));
                                }

                                break;
                        }
                    }
                }
            }
        }

        private void TSM_NuevoGrupo_Click(object sender, EventArgs e)
        {
            FRM_Group tForm = new FRM_Group();
            tForm.Owner = this;
            tForm.ShowDialog();
        }

        private void TSM_Editar_Click(object sender, EventArgs e)
        {
            FRM_Group tForm = new FRM_Group();
            tForm.iIDGroup = TRV_Lista.SelectedNode.Index;
            tForm.ShowDialog();
        }

        private void TSM_Eliminar_Click(object sender, EventArgs e)
        {
            String sIDGrupo = CLS_DataManager.Instance.getListGroup.ElementAt(TRV_Lista.SelectedNode.Index).aID;

            if (CLS_DataManager.Instance.isDataExists(sIDGrupo))
            {
                if (MessageBox.Show(this, "Este grupo tiene datos asociados. ¿Desea eliminar-los?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS_DataManager.Instance.deleteDataByGroup(sIDGrupo);

                }
                else
                {
                    MessageBox.Show(this, "No es posible eliminar el grupo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            CLS_DataManager.Instance.deleteGroup(sIDGrupo);
            CLS_DataManager.Instance.loadGroups();
            CLS_DataManager.Instance.loadData();

            LSV_Data.Items.Clear();
        }

        private void LSV_Data_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (LSV_Data.SelectedIndices.Count > 0)
                {
                    MN_Datos.Items[0].Enabled = false;
                    MN_Datos.Items[1].Enabled = true;
                    MN_Datos.Items[2].Enabled = true;
                }
                else
                {
                    MN_Datos.Items[0].Enabled = true;
                    MN_Datos.Items[1].Enabled = false;
                    MN_Datos.Items[2].Enabled = false;
                }

                MN_Datos.Show(LSV_Data, new Point(e.X, e.Y));
            }
        }

        private void TSM_NuevaEntrada_Click(object sender, EventArgs e)
        {
            TS_NuevaEntrada_Click(sender, e);
        }

        private void TSM_EditarEntrada_Click(object sender, EventArgs e)
        {
            if (LSV_Data.SelectedIndices.Count > 0)
            {
                FRM_Entry tForm = new FRM_Entry();
                tForm.Owner = this;
                tForm.iIDEntry = int.Parse(LSV_Data.SelectedItems[0].Tag.ToString());
                tForm.ShowDialog();
            }
        }

        private void TSM_EliminarEntrada_Click(object sender, EventArgs e)
        {
            if (LSV_Data.SelectedIndices.Count > 0)
            {
                CLS_DataManager.Instance.deleteData(LSV_Data.SelectedItems[0].Tag.ToString());
                CLS_DataManager.Instance.loadData();

                TRV_Lista_NodeMouseClick(sender, null);
            }
        }

        private void MN_GenClaves_Click(object sender, EventArgs e)
        {
            FRM_PassGen tForm = new FRM_PassGen();
            tForm.ShowDialog();
        }

        private void MN_NuevaDB_Click(object sender, EventArgs e)
        {
            TS_NuevaDB_Click(sender, e);
        }

        private void MN_Abrir_Click(object sender, EventArgs e)
        {
            TS_Abrir_Click(sender, e);
        }

        private void MN_ClaveMaestra_Click(object sender, EventArgs e)
        {
            if (CLS_Globals.tDBManager != null)
            {
                if (CLS_Auth.Instance.IsAccessGranted)
                {
                    if (CLS_Auth.Instance.isValidKey())
                    {
                        FRM_MasterKey tForm = new FRM_MasterKey();
                        tForm.Owner = this;
                        tForm.ShowDialog();
                    }
                }
            }
        }

        private void MN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MN_AcercaDe_Click(object sender, EventArgs e)
        {
            FRM_About tForm = new FRM_About();
            tForm.ShowDialog();
        }

        public void TRV_Lista_NodeMouseClick(object sender)
        {
            TRV_Lista_NodeMouseClick(sender, null);
        }
    }
}
