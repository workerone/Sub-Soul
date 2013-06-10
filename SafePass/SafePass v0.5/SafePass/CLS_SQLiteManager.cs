using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;

namespace SafePass
{
    class CLS_SQLiteManager
    {
        private SQLiteConnection tConnection;
        private String sFilePath;

        // Constructor
        public CLS_SQLiteManager(String aFilePath)
        {
            this.sFilePath = aFilePath;
            this.tConnection = new SQLiteConnection();
        }

        public String aFilePath
        {
            get
            {
                return this.sFilePath;
            }

            set
            {
                this.sFilePath = value;
            }
        }
        
        // sentencias SELECT
        public SQLiteDataReader execQuery(String sQuery)
        {
            if (this.sFilePath == null)
                return null;

            try
            {
                this.tConnection.Close();
                this.tConnection.ConnectionString = "Data Source=" + this.sFilePath + "; Version=3; New=False; Compress=True;";
                this.tConnection.Open();

                SQLiteCommand tSqliteCommand = new SQLiteCommand(sQuery, this.tConnection);
                SQLiteDataReader tRet = tSqliteCommand.ExecuteReader();

                return tRet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        // sentencias CREATE / INSERT / UPDATE / DELETE / DROP
        public void execNonQuery(String sQuery)
        {
            if (this.sFilePath == null)
                return;

            try
            {
                this.tConnection.Close();
                this.tConnection.ConnectionString = "Data Source=" + this.sFilePath + "; Version=3; New=False; Compress=True;";
                this.tConnection.Open();

                SQLiteCommand tSqliteCommand = new SQLiteCommand(sQuery, this.tConnection);
                tSqliteCommand.ExecuteNonQuery();

                this.tConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Cierra la conexión
        public void closeConexion()
        {
            try
            {
                this.tConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
