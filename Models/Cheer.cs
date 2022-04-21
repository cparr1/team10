using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class Cheer
    {
        public int CheerID { get; set; }
        public Guid CentricUserID { get; set; }
        [Display(Name = "Cheer Getter")]
        public Guid CheerGetter { get; set; }
        [Display(Name = "Short Description")]
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
       [Display(Name = "Core Value Cheered")]
       public CoreValue CoreValueCheered { get; set; }
       [ForeignKey("CentricUserID")]
       [Display(Name = "Cheer Sender")]
       public virtual CentricUser CheerSender { get; set; }
       [ForeignKey("CheerGetter")]
       public virtual CentricUser CheerReciever { get; set; }

    }
}