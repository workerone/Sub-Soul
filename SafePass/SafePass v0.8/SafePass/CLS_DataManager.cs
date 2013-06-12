using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace SafePass
{
    class CLS_DataManager
    {
        private static CLS_DataManager tDataManager = new CLS_DataManager();
        
        private List<CLS_Group> tListGroup = new List<CLS_Group>();
        private List<CLS_Data> tListData = new List<CLS_Data>();

        private CLS_SQLiteManager tSQLManager;
        private CLS_Security tSecurity;
  
        private TreeView tTreeView;
        private StatusStrip tStatusStrip;
        private String sDBName;

        public static CLS_DataManager Instance
        {
            get
            {
                if (tDataManager == null)
                {
                    tDataManager = new CLS_DataManager();
                }

                return tDataManager;
            }
        }

        public void initialize(CLS_SQLiteManager tDBManager, CLS_Security tSecurity, String sDBName)
        {
            this.tSQLManager = tDBManager;
            this.tSecurity = tSecurity;
            this.sDBName = sDBName;
        }

        // Setea el treeview
        public void setProperties(TreeView tTreeView, StatusStrip tStatusStrip)
        {
            this.tTreeView = tTreeView;
            this.tStatusStrip = tStatusStrip;
        }

        // Devuelve un array de grupos
        public List<CLS_Group> getListGroup
        {
            get
            {
                return this.tListGroup;
            }

            set
            {
                this.tListGroup = value;
            }
        }

        // Devuelve un array de datos
        public List<CLS_Data> getListData
        {
            get
            {
                return this.tListData;
            }

            set
            {
                this.tListData = value;
            }
        }

        // Carga los grupos en un array desde la base de datos
        public void loadGroups()
        {
            if (this.tTreeView != null) 
            {
                this.tTreeView.Nodes.Clear();
                this.tTreeView.Nodes.Add(sDBName);
                this.tTreeView.Nodes[0].Nodes.Clear();
                this.tListGroup.Clear();

                String sQuery = "SELECT * FROM grupos";
                SQLiteDataReader tReader = this.tSQLManager.execQuery(sQuery);

                if (tReader != null)
                {
                    while (tReader.Read())
                    {
                        TreeNode tNodo = new TreeNode();

                        switch (tReader.GetValue(1).ToString())
                        {
                            case "Windows":
                                tNodo.ImageIndex = 1;
                                tNodo.SelectedImageIndex = 1;
                                break;
                            case "Correo":
                                tNodo.ImageIndex = 2;
                                tNodo.SelectedImageIndex = 2;
                                break;
                            case "Internet":
                                tNodo.ImageIndex = 3;
                                tNodo.SelectedImageIndex = 3;
                                break;
                            case "General":
                                tNodo.ImageIndex = 4;
                                tNodo.SelectedImageIndex = 4;
                                break;
                            case "Cuentas Premium":
                                tNodo.ImageIndex = 5;
                                tNodo.SelectedImageIndex = 5;
                                break;
                            case "Otros":
                                tNodo.ImageIndex = 6;
                                tNodo.SelectedImageIndex = 6;
                                break;
                            default:
                                tNodo.ImageIndex = 7;
                                tNodo.SelectedImageIndex = 7;
                                break;
                        }

                        tNodo.Text = Convert.ToString(tReader.GetValue(1));
                        this.tTreeView.Nodes[0].Nodes.Add(tNodo);

                        CLS_Group tGrupo = new CLS_Group
                        (
                            tReader.GetValue(0).ToString(),
                            tReader.GetValue(1).ToString(),
                            tReader.GetValue(2).ToString()
                        );

                        this.tListGroup.Add(tGrupo);
                    }
                }

                tReader.Close();
                this.tSQLManager.closeConnection();
                this.tTreeView.ExpandAll();
            }
        }

        // Carga la data en un array desde la base de datos
        public void loadData()
        {
            this.tListData.Clear();

            String sQuery = "SELECT * FROM data";
            SQLiteDataReader tReader = this.tSQLManager.execQuery(sQuery);

            if (tReader != null)
            {
                while (tReader.Read())
                {
                    CLS_Data tData = new CLS_Data
                    (
                        tReader.GetValue(0).ToString(),
                        this.tSecurity.DencData(tReader.GetValue(1).ToString()),
                        this.tSecurity.DencData(tReader.GetValue(2).ToString()),
                        this.tSecurity.DencData(tReader.GetValue(3).ToString()),
                        this.tSecurity.DencData(tReader.GetValue(4).ToString()),
                        this.tSecurity.DencData(tReader.GetValue(5).ToString()),
                        tReader.GetValue(6).ToString()
                    );

                    this.tListData.Add(tData);
                }
            }

            tReader.Close();
            this.tSQLManager.closeConnection();
            this.tStatusStrip.Items[0].Text = "Total entrada(s): " + this.tListData.Count;
        }

        // Actualiza toda la información de forma masiva
        public void updateAllData()
        {
            for (int i = 0; i < this.tListData.Count; i++)
            {
                CLS_DataManager.Instance.updateData
                (
                    this.tListData.ElementAt(i).aID,
                    this.tListData.ElementAt(i).aTitulo,
                    this.tListData.ElementAt(i).aUser,
                    this.tListData.ElementAt(i).aPassword,
                    this.tListData.ElementAt(i).aURL,
                    this.tListData.ElementAt(i).aDetalle,
                    this.tListData.ElementAt(i).aIDGrupo
                );
            }
        }

        // Comprueba si un grupo ya existe o no
        public Boolean isGroupExists(String sName)
        {
            for (int i = 0; i < this.tListGroup.Count; i++)
            {
                if (this.tListGroup.ElementAt(i).aNombre.Equals(sName))
                {
                    return true;
                }
            }

            return false;
        }

        // Comprueba si la id existe o no
        public Boolean isDataExists(String sID)
        {
            for (int i = 0; i < this.tListData.Count; i++)
            {
                if (this.tListData.ElementAt(i).aIDGrupo.Equals(sID))
                {
                    return true;
                }
            }

            return false;
        }

        // Devuelve la información a partir de su id
        public CLS_Data getDataByID(String sID)
        {
            for (int i = 0; i < this.tListData.Count; i++)
            {
                if (this.tListData.ElementAt(i).aID.Equals(sID))
                {
                    return this.tListData.ElementAt(i);
                }
            }

            return null;
        }

        // Devuelve el nombre del grupo a partir de su id
        public String getGroupNameByID(String sID)
        {
            for (int i = 0; i < this.tListGroup.Count; i++)
            {
                if (this.tListGroup.ElementAt(i).aID.Equals(sID))
                {
                    return this.tListGroup.ElementAt(i).aNombre;
                }
            }

            return null;
        }

        // Añade un grupo a partir del nombre
        public void addGroup(String sName) 
        {
            String sQuery = "INSERT INTO grupos VALUES(NULL, '" + sName + "', NULL)";
            Console.WriteLine(sQuery);
            this.tSQLManager.execNonQuery(sQuery);
        }

        // Actualiza un grupo a partir de la id y un nombre
        public void updateGroup(String sName, String sID)
        {
            String sQuery = "UPDATE grupos SET name = '" + sName + "' WHERE id = " + sID;
            Console.WriteLine(sQuery);
            this.tSQLManager.execNonQuery(sQuery);
        }

        // Elimina un grupo a partir de su id
        public void deleteGroup(String sID)
        {
            String sQuery = "DELETE FROM grupos WHERE id = " + sID;
            Console.WriteLine(sQuery);
            this.tSQLManager.execNonQuery(sQuery);
        }

        // Añade nueva información a la base de datos
        public void addData(String sTitle, String sUser, String sPass, String sURL, String sDetail, String sIDGroup)
        {
            String sQuery = "INSERT INTO data VALUES(NULL, '" +
                                this.tSecurity.EncData(sTitle) + "', '" +
                                this.tSecurity.EncData(sUser) + "', '" +
                                this.tSecurity.EncData(sPass) + "', '" +
                                this.tSecurity.EncData(sURL) + "', '" +
                                this.tSecurity.EncData(sDetail) + "', " + sIDGroup + ")";

            Console.WriteLine(sQuery);
            this.tSQLManager.execNonQuery(sQuery);
        }

        // Actualiza información a la base de datos
        public void updateData(String sID, String sTitle, String sUser, String sPass, String sURL, String sDetail, String sIDGroup)
        {
            String sQuery = "UPDATE data SET " +
                            "title = '" + this.tSecurity.EncData(sTitle) + "', " +
                            "username = '" + this.tSecurity.EncData(sUser) + "', " +
                            "password = '" + this.tSecurity.EncData(sPass) + "', " +
                            "url = '" + this.tSecurity.EncData(sURL) + "', " +
                            "detail = '" + this.tSecurity.EncData(sDetail) + "', " +
                            "id_grupo = " + sIDGroup + " WHERE id = " + sID;

            Console.WriteLine(sQuery);
            this.tSQLManager.execNonQuery(sQuery);
        }

        // Elimina la información a partir de la id
        public void deleteData(String sID)
        {
            String sQuery = "DELETE FROM data WHERE id = " + sID;
            Console.WriteLine(sQuery);
            this.tSQLManager.execNonQuery(sQuery);
        }

        // Elimina la información a partir de la id del grupo
        public void deleteDataByGroup(String sID)
        {
            String sQuery = "DELETE FROM data WHERE id_grupo = " + sID;
            Console.WriteLine(sQuery);
            this.tSQLManager.execNonQuery(sQuery);
        }
    }
}
