using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Posts
    {
        [Key]
        [Display(Name = "Post Id")]
        public int PostId { get; set; }
        [Required]
        [Display(Name = "Message")]
        public int PostMsg { get; set; }

        [Required]
        [Display(Name = "Time")]
        public DateTime PostTime { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public Users userId { get; set; }
    }
}