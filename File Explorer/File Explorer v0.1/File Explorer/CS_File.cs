using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace File_Explorer
{
    class CS_File
    {
        private String sName;
        private String sSize;
        private String sAtrributes;

        public String aName
        {
            get
            {
                return sName;
            }
            set
            {
                sName = value;
            }
        }

        public String aSize
        {
            get
            {
                return sSize;
            }
            set
            {
                sSize = value;
            }
        }

        public String aAtrributes
        {
            get
            {
                return sAtrributes;
            }
            set
            {
                sAtrributes = value;
            }
        }
    }
}
