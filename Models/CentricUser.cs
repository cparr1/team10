using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class CentricUser
    {
        public int CentricUserID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int UserTitleID { get; set; }
        public int OfficeLocationID { get; set; }
        public DateTime birthday { get; set; }
        public int CoreValueID { get; set; }
        public virtual OfficeLocation OfficeLocations { get; set; }
        public virtual CoreValue CoreValues { get; set; }
        public virtual UserTitle UserTitles { get; set; }
    }
}