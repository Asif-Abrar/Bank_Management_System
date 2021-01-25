using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMS.Models
{
    public class Login
    {
        [Display(Name="User ID")]
        [Key]
        public int Id { get; set; }
        public string Password { get; set; }
    }
}