using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace SafePass
{
    class CLS_Auth
    {
        private static CLS_Auth tAuth = new CLS_Auth();

        private CLS_SQLiteManager tSQLManager;
        private CLS_Security tSecurity;
        private Boolean bAccessGranted;

        public static CLS_Auth Instance
        {
            get
            {
                if (tAuth == null)
                {
                    tAuth = new CLS_Auth();
                }

                return tAuth;
            }
        }

        public void initialize(CLS_SQLiteManager tDBManager, CLS_Security tSecurity)
        {
            this.tSQLManager = tDBManager;
            this.tSecurity = tSecurity;
        }

        // Obtiene la clave desde la base de datos
        public String getMasterKey()
        {
            String sRet = null;
            String sQuery = "SELECT key FROM enc";
            SQLiteDataReader tReader = this.tSQLManager.execQuery(sQuery);

            if (tReader.HasRows)
            {
                tReader.Read();
                sRet = tReader.GetValue(0).ToString();
            }

            tReader.Close();
            this.tSQLManager.closeConnection();

            return sRet;
        }

        // Inserta o actualiza la clave en la base de datos
        public void setMasterKey()
        {
            String sQuery = "SELECT * FROM enc";

            SQLiteDataReader tReader = this.tSQLManager.execQuery(sQuery);

            if (tReader.HasRows)
            {
                sQuery = "UPDATE enc SET key = '" + this.tSecurity.EncData("SafePass") + "'";
            }
            else
            {
                sQuery = "INSERT INTO enc VALUES(NULL, '" + this.tSecurity.EncData("SafePass") + "')";
            }
        
            Console.WriteLine(sQuery);
            tReader.Close();

            this.tSQLManager.closeConnection();
            this.tSQLManager.execNonQuery(sQuery);
        }

        // Verifica si se concedio el acceso a la información
        public Boolean IsAccessGranted
        {
            get
            {
                return this.bAccessGranted;
            }

            set
            {
                this.bAccessGranted = value;
            }
        }

        // Comprueba si existe la clave o no
        public Boolean isKeyExists()
        {
            Boolean bRet = false;
            String sQuery = "SELECT key FROM enc";
            SQLiteDataReader tReader = this.tSQLManager.execQuery(sQuery);

            if (tReader.HasRows)
            {
                bRet = true;
            }

            tReader.Close();
            this.tSQLManager.closeConnection();

            return bRet;
        }

        // Comprueba si la clave es valida o no
        public Boolean isValidKey()
        {
            Boolean bRet = false;
            String sQuery = "SELECT key FROM enc";
            SQLiteDataReader tReader = this.tSQLManager.execQuery(sQuery);

            if (tReader.HasRows)
            {
                tReader.Read();
                String sMasterKey = tReader.GetValue(0).ToString();

                if (sMasterKey.Equals(this.tSecurity.EncData("SafePass")))
                {
                    bRet = true;
                }
            }

            tReader.Close();
            this.tSQLManager.closeConnection();

            return bRet;
        }

        // Comprueba si la clave es valida o no
        public Boolean isValidKey(String sKey)
        {
            Boolean bRet = false;

            if (sKey.Equals(this.tSecurity.aPassword))
            {
                bRet = true;
            }

            return bRet;
        }
    }
}
