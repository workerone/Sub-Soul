using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePass
{
    class CLS_Data
    {
        private String sID;
        private String sTitle;
        private String sUser;
        private String sPassword;
        private String sURL;
        private String sDetail;
        private String sIDGroup;

        public CLS_Data(String sID, String sTitle, String sUser, String sPassword, String sURL, String sDetail, String sIDGroup)
        {
            this.sID = sID;
            this.sTitle = sTitle;
            this.sUser = sUser;
            this.sPassword = sPassword;
            this.sURL = sURL;
            this.sDetail = sDetail;
            this.sIDGroup = sIDGroup;
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

        public String aTitulo
        {
            get
            {
                return this.sTitle;
            }
            set
            {
                this.sTitle = value;
            }
        }

        public String aUser
        {
            get
            {
                return this.sUser;
            }
            set
            {
                this.sUser = value;
            }
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

        public String aURL
        {
            get
            {
                return this.sURL;
            }
            set
            {
                this.sURL = value;
            }
        }

        public String aDetalle
        {
            get
            {
                return this.sDetail;
            }
            set
            {
                this.sDetail = value;
            }
        }

        public String aIDGrupo
        {
            get
            {
                return this.sIDGroup;
            }
            set
            {
                this.sIDGroup = value;
            }
        }
    }
}
