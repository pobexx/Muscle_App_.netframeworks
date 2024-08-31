using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Muscle_App_.NetFrameworks.Models.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Email is needed")]
        [EmailAddress(ErrorMessage = "Confirm your Email")]
        
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is needed")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!@#$%^&*]).{8,}$",
        ErrorMessage = "パスワードは最低8文字以上で、少なくとも1つの数字、1つの大文字、1つの小文字、1つの特殊文字(!@#$%^&*)を含む必要があります。")]
        public string Password { get; set; }

        public bool IsDevelopmentMode { get; set; }

        public List<User> Users {  get; set; }
    }
}