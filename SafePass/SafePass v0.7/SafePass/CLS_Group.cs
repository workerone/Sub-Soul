using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePass
{
    public class CLS_Group
    {
        private String sID;
        private String sName;
        private String sDesc;

        public CLS_Group(String sID, String sName, String sDesc)
        {
            this.sID = sID;
            this.sName = sName;
            this.sDesc = sDesc;
        }

        public String aID
        {
            get
            {
                return this.sID;
            }
            set
            {
                this.sID = value;
            }
        }

        public String aNombre
        {
            get
            {
                return this.sName;
            }
            set
            {
                this.sName = value;
            }
        }

        public String aDesc
        {
            get
            {
                return this.sDesc;
            }
            set
            {
                this.sDesc = value;
            }
        }
    }
}
