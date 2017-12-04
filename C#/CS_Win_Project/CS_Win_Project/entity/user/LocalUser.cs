using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Win_Project.entity.user
{
    [Serializable]
    class LocalUser
    {
        public string name{get;set;}
        public string password { get; set; }
        public bool isAuto { get; set; }
        public bool isSave { get; set; }

        public LocalUser()
        {

        }
        public LocalUser(string userName, string password)
        {
            this.name = userName;
            this.password = password;
        }


    }
}
