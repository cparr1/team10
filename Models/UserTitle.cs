using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class UserTitle
    {
        public int UserTitleID { get; set; }
        public string titleName { get; set; }
        public virtual CentricUser CentricUser
    }
}