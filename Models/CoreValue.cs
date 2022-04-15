using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class CoreValue
    {
        public int coreValueID { get; set; }
        [Display(Name = "Core Value")]
        [Required(ErrorMessage = "Please Select a Core Value")]
        public string valueName { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please Enter a Short Description of Value")]
        public string valueDescription { get; set; }
        public virtual ICollection<CentricUser> CentricUser { get; set; }
    }
}