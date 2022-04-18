using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class Cheer
    {
        public int CheerID { get; set; }
        public Guid CentricUserID { get; set; }
        public Guid CheerGetter { get; set; }
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
       public CoreValue CoreValueCheered { get; set; }
       [ForeignKey("CentricUserID")]
       public virtual CentricUser CheerSender { get; set; }
       [ForeignKey("CheerGetter")]
       public virtual CentricUser CheerReciever { get; set; }

    }
}