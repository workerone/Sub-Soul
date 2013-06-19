using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace File_Explorer
{
    class CS_Functions
    {
        // Estructura
        struct TFileInfo
        {
            public String sFileName;
            public long lFileSize;
            public FileAttributes tFileAtrr;
        }

        // Obtiene las unidades logicas
        public static String getLogicDrives()
        {
            String sRet = null;

            for (int i = 0; i < DriveInfo.GetDrives().Count(); i++)
            {
                sRet += DriveInfo.GetDrives().ElementAt(i) + "\n";
            }

            return sRet;
        }

        // Obtiene las carpetas de un directorio
        public static String getDirFolders(String sPath)
        {
            String sRet = null;

            try
            {
                String[] sArrFolders = Directory.GetDirectories(sPath);

                var pqFolders = from sFile in sArrFolders.AsParallel().AsOrdered()
                                let sName = new DirectoryInfo(sFile).Name
                                select sName;

                foreach (var pqFolder in pqFolders)
                {
                    sRet += pqFolder + "\n";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
                sRet = null;
            }

            return sRet;
        }

        // Obtiene los ficheros de un directorio
        public static List<CS_File> getDirFiles(String sPath)
        {
            List<CS_File> tRet = new List<CS_File>();

            try
            {
                String[] sArrFiles = Directory.GetFiles(sPath);

                var pqFiles = from sFile in sArrFiles.AsParallel().AsOrdered()
                              let sName = new FileInfo(sFile).Name
                              let sSize = new FileInfo(sFile).Length
                              let sAtrr = File.GetAttributes(sFile)
                              select new TFileInfo { sFileName = sName, lFileSize = sSize, tFileAtrr = sAtrr};

                foreach (var pqFile in pqFiles)
                {
                    CS_File tFile = new CS_File();
                    tFile.aName = pqFile.sFileName;
                    tFile.aSize = sizeConvert(pqFile.lFileSize);
                    tFile.aAtrributes = pqFile.tFileAtrr.ToString();
                    tRet.Add(tFile);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
                tRet = null;
            }

            return tRet;
        }

        // Comprueba si un directorio existe
        public static Boolean isDirExists(String sPath)
        {
            Boolean bRet = false;

            if (new DirectoryInfo(sPath).Exists)
            {
                bRet = true;
            }

            return bRet;
        }

        // Comprueba si un directorio es accesible (Permisos)
        public static Boolean isDirAccessible(String sPath)
        {
            Boolean bRet = true;

            try
            {
                String[] sArrFiles = Directory.GetFiles(sPath);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
                bRet = false;
            }

            return bRet;
        }

        // Comprueba si en el directorio existen carpetas
        public static int getDirContentCount(String sPath)
        {
            try
            {
                return Directory.GetDirectories(sPath).Count();
            }
            catch (UnauthorizedAccessException ex)
            {

                return 0;
            }
        }

        // Obtiene la ruta anterior a partir de la actual
        public static String getPrevPath(String sPath)
        {
            String sTemp = null;
            int iPos = -1;

            sTemp = reverseString(sPath);
            iPos = sTemp.IndexOf("\\");

            if (iPos > -1)
            {
                sTemp = sTemp.Substring(iPos + 1);
                sTemp = reverseString(sTemp);

                if (sTemp.IndexOf("\\") == -1)
                {
                    sTemp += "\\";
                }
            }

            return sTemp;
        }

        // Invierte cadenas de texto
        public static String reverseString(string sData)
        {
            if (sData == null) return null;

            char[] array = sData.ToCharArray();
            Array.Reverse(array);

            return new String(array);
        }

        // Formatea el tamaño en Bytes
        public static string sizeConvert(long lSize)
        {
            const int iBytes = 1024;
            Double dBytes = Convert.ToDouble(lSize);

            if (dBytes >= Math.Pow(iBytes, 3))
            {
                return string.Concat(Math.Round(dBytes / Math.Pow(iBytes, 3), 2), " GB");
            }
            else if (dBytes >= Math.Pow(iBytes, 2))
            {
                return string.Concat(Math.Round(dBytes / Math.Pow(iBytes, 2), 2), " MB");
            }
            else if (dBytes >= iBytes)
            {
                return string.Concat(Math.Round(dBytes / iBytes, 2), " KB");
            }
            else
            {
                return string.Concat(dBytes, " Bytes");
            }
        }

        public static byte[] iconToBytes(String sFile)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Icon tIcon = Icon.ExtractAssociatedIcon(sFile);
                tIcon.Save(ms);

                return ms.ToArray();
            }
        }
    }
}
