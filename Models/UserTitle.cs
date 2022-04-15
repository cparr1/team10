using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class UserTitle
    {
        public int UserTitleID { get; set; }
        [Display(Name = "Job Title")]
        [Required(ErrorMessage = "Please Select Job Title")]
        public string titleName { get; set; }
        public virtual ICollection<CentricUser> CentricUser { get; set; }
    }
}