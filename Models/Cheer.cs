using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class Cheer
    {
        public int CheerID { get; set; }
        public Guid CentricUserID { get; set; }
        public virtual CentricUser CheerGetter { get; set; }
        public string ShortDesc { get; set; }
        public enum CoreValue
        {
            Excellence = 1,
            Integrity = 2,
            Stewardship = 3,
            Innovate = 4,
            Balance = 5,
            Greater_Good = 6,
            Culture = 7
        }
    }
}