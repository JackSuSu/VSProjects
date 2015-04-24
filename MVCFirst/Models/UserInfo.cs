using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirst.Models
{
    public class UserInfo
    {

        private int id;

        public int UId
        {
            get { return id; }
            set { id = value; }
        }


        private string Uname;

        public string UName
        {
            get { return Uname; }
            set { Uname = value; }
        }

        private string upwd;    

        public string UPwd
        {
            get { return upwd; }
            set { upwd = value; }
        }


        private int ugid;

        public int  UGid
        {
            get { return ugid; }
            set { ugid = value; }
        }

        
        


    }
}