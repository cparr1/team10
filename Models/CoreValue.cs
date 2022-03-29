using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class CoreValue
    {
        public int coreValueID { get; set; }
        public string valueName { get; set; }
        public virtual CentricUser CentricUser
    }
}