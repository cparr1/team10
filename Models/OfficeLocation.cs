using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class OfficeLocation
    {
        public int OfficeLocationID { get; set; }
        public string locationName { get; set; }
        public virtual CentricUser CentricUser
    }
}