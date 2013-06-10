using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SafePass
{
    class CLS_DBManager
    {
        private CLS_SQLiteManager tSQLManager;
        private String sFilePath;

        // Constructor
        public CLS_DBManager()
        {
        }

        // Constructor
        public CLS_DBManager(String sFilePath)
        {
            this.sFilePath = sFilePath;
        }

        public void initialize(String sFilePath)
        {
            this.sFilePath = sFilePath;
        }

        // Extrae una db sqlite nueva en la ruta indicada
        public void newDatabase()
        {
            byte[] bArrData = new byte[SafePass.Properties.Resources._default.Length];
            bArrData = SafePass.Properties.Resources._default;
            File.WriteAllBytes(sFilePath, bArrData);
        }

        // Carga la base de datos a partir de la ruta indicada
        public void loadDatabase()
        {
            if (this.tSQLManager == null)
            {
                this.tSQLManager = new CLS_SQLiteManager(this.sFilePath);
            }
            else
            {
                this.tSQLManager.aFilePath = this.sFilePath;
            }
        }

        // Comprueba si la base de datos es correcta
        public Boolean isValidDatabase()
        {
            String sQuery = "SELECT COUNT(*) FROM sqlite_master " +
                            "WHERE type IN ('table') " +
                            "AND name NOT LIKE 'sqlite_%'";

            SQLiteDataReader tReader = this.tSQLManager.execQuery(sQuery);

            if (tReader.HasRows)
            {
                tReader.Read();

                if (!tReader.GetValue(0).ToString().Equals("3"))
                        return false;

                sQuery = "SELECT name FROM sqlite_master " +
                            "WHERE type IN ('table') " +
                            "AND name NOT LIKE 'sqlite_%'";

                tReader = this.tSQLManager.execQuery(sQuery);

                if (tReader.HasRows)
                {
                    while (tReader.Read())
                    {
                        if (!tReader.GetValue(0).ToString().ToLower().Equals("data") &&
                            !tReader.GetValue(0).ToString().ToLower().Equals("enc") &&
                            !tReader.GetValue(0).ToString().ToLower().Equals("grupos"))
                            return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        // Devuelve la instancia
        public CLS_SQLiteManager getDatabase
        {
            get
            {
                return this.tSQLManager;
            }
        }
    }
}
