using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace team10.Models
{
    public class CentricUser
    { 
        [Display(Name = "Centric User ID")]
        [Required(ErrorMessage = "Please Enter Centric User ID")]
        public Guid CentricUserID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter Your First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public string lastName { get; set; }
        public int UserTitleID { get; set; }
        public int OfficeLocationID { get; set; }

        [Display(Name = "Birthday")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Select Your Birthday.")]
        public DateTime birthday { get; set; }
        public int CoreValueID { get; set; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please Select Office Location")]
        public virtual OfficeLocation OfficeLocations { get; set; }

        [Display(Name = "Core Value")]
        [Required(ErrorMessage = "Pleas Enter A Core Value")]
        public virtual CoreValue CoreValues { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please Select Title")]
        public virtual UserTitle UserTitles { get; set; }
    }
}