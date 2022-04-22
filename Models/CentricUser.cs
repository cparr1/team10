using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public enum Title
        {
            Consultant = 1,
            Senior_Consultant = 2,
            Manager = 3,
            Senior_Manager = 4,
            Director = 5,
            Vice_President= 6,
          
        }
        public Title UserTitle { get; set; }
        public enum Location
        {
                Boston = 1,
                Charlotte = 2,
                Chicago = 3,
                Cincinnati = 4,
                Cleveland = 5,
                Columbus = 6,
                Detroit = 7,
                India = 8,
                Indianapolis = 9,
                Louisville = 10,
                Miami = 11,
                Seattle = 12,
                Saint_Louis = 13,
                Tampa = 14,

        }
        public Location UserLocation { get; set; }
        [ForeignKey("CheerGetter")]
        public virtual ICollection<Cheer> CheerGetter { get; set; }
        [ForeignKey("CentricUserID")]
        public virtual ICollection<Cheer> CheerSender { get; set; }
        
    }
}