using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class OfficeLocation
    {
        public int OfficeLocationID { get; set; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please Select Office Location")]
        public string locationName { get; set; }
        public virtual ICollection<CentricUser> CentricUser { get; set; }
    }
}