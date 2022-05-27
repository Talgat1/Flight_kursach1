using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace Flight_kursach.Services.Identity.ManageViewModels
{
    public class EnableAuthenticatorViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "Пароль должен быть не меньше {2} и не больше {1} символов.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Verification Code")]
        public string Code { get; set; }

        [BindNever]
        public string SharedKey { get; set; }

        [BindNever]
        public string AuthenticatorUri { get; set; }
    }
}
