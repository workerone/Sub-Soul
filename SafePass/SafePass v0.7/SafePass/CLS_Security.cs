using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SafePass
{
    class CLS_Security : CLS_AES
    {
        private const String CST_SALT = "SafePass";

        // Contructor
        public CLS_Security()
        {
        }

        // Contructor
        public CLS_Security(String sPassword) : base(sPassword, CST_SALT)
        {
        }

        // Setea la contraseña
        public void setPassword(String sPassword) 
        {
            this.aPassword = sPassword;
            this.aSalt = CST_SALT;
        }

        // Encripta la información
        public String EncData(String sData)
        {
            this.aData = sData;
            this.Encrypt();

            return this.aResult;
        }

        // Desencripta la información
        public String DencData(String sData)
        {
            this.aData = sData;
            this.Decrypt();

            return this.aResult;
        }
    }
}
