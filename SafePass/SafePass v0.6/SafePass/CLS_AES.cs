using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SafePass
{
    class CLS_AES
    {
        private String sPassword;
        private String sSalt;
        private String sData;
        private String sRet;

        public CLS_AES()
        {
        }

        public CLS_AES(String sPassword, String sSalt)
        {
            this.sPassword = sPassword;
            this.sSalt = sSalt;
        }

        public String aPassword
        {
            get
            {
                return this.sPassword;
            }

            set
            {
                this.sPassword = value;
            }
        }

        public String aSalt
        {
            get
            {
                return this.sSalt;
            }

            set
            {
                this.sSalt = value;
            }
        }

        public String aData
        {
            get
            {
                return this.sData;
            }

            set
            {
                this.sData = value;
            }
        }

        public String aResult
        {
            get
            {
                return this.sRet;
            }
        }

        public void Encrypt()
        {
            AesCryptoServiceProvider tAES = new AesCryptoServiceProvider();
            DeriveBytes tDB = new Rfc2898DeriveBytes(sPassword, Encoding.Unicode.GetBytes(sSalt), 9);

            byte[] bKey = tDB.GetBytes(tAES.KeySize >> 3);
            byte[] bIv = tDB.GetBytes(tAES.BlockSize >> 3);

            tAES.Mode = CipherMode.CBC;
            tAES.Key = bKey;
            tAES.IV = bIv;

            ICryptoTransform tEncypt = tAES.CreateEncryptor();

            try
            {
                byte[] bData = Encoding.Unicode.GetBytes(sData);
                byte[] bDataEncrypt = tEncypt.TransformFinalBlock(bData, 0, bData.Length);

                this.sRet = Convert.ToBase64String(bDataEncrypt);
            }
            catch (Exception e)
            {
                this.sRet = null;
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void Decrypt()
        {
            AesCryptoServiceProvider tAES = new AesCryptoServiceProvider();
            DeriveBytes tDB = new Rfc2898DeriveBytes(sPassword, Encoding.Unicode.GetBytes(sSalt), 9);

            byte[] bKey = tDB.GetBytes(tAES.KeySize >> 3);
            byte[] bIv = tDB.GetBytes(tAES.BlockSize >> 3);

            tAES.Mode = CipherMode.CBC;
            tAES.Key = bKey;
            tAES.IV = bIv;

            ICryptoTransform tDecrypt = tAES.CreateDecryptor();

            try
            {
                byte[] bData = Convert.FromBase64String(sData);
                byte[] bDataDecrypt = tDecrypt.TransformFinalBlock(bData, 0, bData.Length);

                this.sRet = Encoding.Unicode.GetString(bDataDecrypt);
            }
            catch (Exception e)
            {
                this.sRet = null;
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
