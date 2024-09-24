using System.ComponentModel.DataAnnotations;

namespace HotCat.BLL.ViewModels.AppUserViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set;}

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name ="Şifre")]
        
        public string Password { get; set;}

        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage = "Email formatında olmalı!")]

        private string _emailAdress;
        public string Email 
        {
            get { return _emailAdress; }
            set
            { 
                var usernameArray = value.Split('@');
                UserName = usernameArray[0];
                _emailAdress = value;
            }

        }

        [Required(ErrorMessage = "Şifre (Tekrar) boş geçilemez!")]
        [Display(Name = "Şifre (Tekrar)")]
        [Compare("Password", ErrorMessage = "Şifreler aynı değil!")]
        public string ConfirmPassword { get; set;}
    }
}
