using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public String UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public String EmailID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public String PhoneNumber { get; set; }

        [Required]
        public String About { get; set; }

        [Required]
        [Display(Name = "Nick Name")]
        public String NickName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public String DateOfBirth { get; set; }

        [Required]
        [DataType(dataType: DataType.ImageUrl)]
        [Display(Name = "Profile Picture")]
        public String ProfilePicture { get; set; }


    }
}