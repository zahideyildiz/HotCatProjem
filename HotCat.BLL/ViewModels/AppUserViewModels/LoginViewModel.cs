using System.ComponentModel.DataAnnotations;

namespace HotCat.BLL.ViewModels.AppUserViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage = "Email formatında olmalı!")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
