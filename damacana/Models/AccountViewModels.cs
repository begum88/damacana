using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace damacana.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen isim giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreleriniz eşleşmelidir")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}