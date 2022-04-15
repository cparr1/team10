using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class Cheer
    {
        public int CheerID { get; set; }
        public virtual ICollection<CentricUser> CheerGetter { get; set; }
        public virtual CoreValue CoreValueCheered { get; set; }
        public string ShortDesc { get; set; }

    }
}