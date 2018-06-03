using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Digital8.Controllers
{
    //context to implement for user login
    public class User
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}