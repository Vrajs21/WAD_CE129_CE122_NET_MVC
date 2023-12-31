﻿using Digital_Classroom.Data;
using System.ComponentModel.DataAnnotations;

namespace Digital_Classroom.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Full name is rquired")]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Display(Name ="User Name")]
        [Required(ErrorMessage ="User Name is required")]
        public string UserName { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password does not match")]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }
}
