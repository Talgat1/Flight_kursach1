using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flight_kursach.Services.Identity.AccountViewModels
{
    public class LoginWithViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "Пароль должен быть не меньше {2} и не больше {1} символов.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Authenticator code")]
        public string TwoFactorCode { get; set; }

        [Display(Name = "Remember this machine")]
        public bool RememberMachine { get; set; }

        public bool RememberMe { get; set; }
    }
}
