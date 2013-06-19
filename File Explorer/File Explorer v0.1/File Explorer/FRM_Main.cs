using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace File_Explorer
{
    public partial class FRM_Main : Form
    {
        String sPresPath;

        public FRM_Main()
        {
            InitializeComponent();
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            sPresPath = null;
            loadDrives();
        }

        private void CMB_Drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            sPresPath = CMB_Drives.SelectedItem.ToString();
            loadFolders(CMB_Drives.SelectedItem.ToString());
        }

        private void LSV_Folders_DoubleClick(object sender, EventArgs e)
        {
            sPresPath += "\\" + LSV_Folders.SelectedItems[0].Text;
            loadFolders(sPresPath);
        }

        private void BTN_Prev_Click(object sender, EventArgs e)
        {
            if (sPresPath != null)
            {
                sPresPath = CS_Functions.getPrevPath(sPresPath);
                loadFolders(sPresPath);
            }
        }

        private void BTN_Root_Click(object sender, EventArgs e)
        {
            sPresPath = CMB_Drives.SelectedItem.ToString();
            loadFolders(CMB_Drives.SelectedItem.ToString());
        }

        private void loadDrives()
        {
            String[] sArrRet = CS_Functions.getLogicDrives().Split('\n');

            for (int i = 0; i < sArrRet.Count() - 1; i++)
            {
                CMB_Drives.Items.Add(sArrRet.ElementAt(i));
            }
        }

        private void loadFolders(String sPath)
        {
            // Comprobamos que el directorio exista y sea accesible
            if (CS_Functions.isDirExists(sPath) && CS_Functions.isDirAccessible(sPath))
            {
                LSV_Folders.Items.Clear();

                // Comprobamos que existan mas directorios dentro del actual
                if (CS_Functions.getDirContentCount(sPath) > 0)
                {
                    LSV_Folders.BeginUpdate();

                    String[] sArrRet = CS_Functions.getDirFolders(sPath).Split('\n');

                    for (int i = 0; i < sArrRet.Count() - 1; i++)
                    {
                        ListViewItem tItem = new ListViewItem();
                        tItem.ImageIndex = 0;
                        tItem.Text = sArrRet.ElementAt(i);
                        LSV_Folders.Items.Add(tItem);
                    }

                    LSV_Folders.EndUpdate();
                }

                loadFiles(sPresPath);
            }
            else
            {
                sPresPath = CS_Functions.getPrevPath(sPresPath);
            }
        }

        private void loadFiles(String sPath)
        {
            // Comprobamos que el directorio exista y sea accesible
            if (CS_Functions.isDirExists(sPath) && CS_Functions.isDirAccessible(sPath))
            {
                LSV_Files.Items.Clear();
                LSV_Files.BeginUpdate();
                List<CS_File> tFiles = new List<CS_File>();

                tFiles = CS_Functions.getDirFiles(sPath);

                for (int i = 0; i < tFiles.Count(); i++)
                {
                    ListViewItem tItem = new ListViewItem();
                    
                    tItem.Text = tFiles.ElementAt(i).aName;
                    tItem.ImageIndex = 1;
                    tItem.SubItems.Add(tFiles.ElementAt(i).aSize);
                    tItem.SubItems.Add(tFiles.ElementAt(i).aAtrributes);

                    LSV_Files.Items.Add(tItem);
                }

                LSV_Files.EndUpdate();
                this.Text = "File Explorer - " + tFiles.Count;
            }
        }
    }
}
