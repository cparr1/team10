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

        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        [Display(Name = "Birthday")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Select Your Birthday.")]
        public DateTime birthday { get; set; }

        public enum UserTitle
        {
            Marketing = 1,
            IT = 2,
            HR = 3,
            IS = 4,
            Finance = 5,
            Managment = 6,
            Sales = 7
        }
        public enum UserLocation
        {
                Chicago = 1,
                Cleveland = 2,
                Columbus = 3,
                Pittsburg = 4,
                Cinncinnati = 5,
                Dallas = 6,
                New_York = 7
        }
        public virtual ICollection<Cheer> Cheer { get; set; }

    }
}