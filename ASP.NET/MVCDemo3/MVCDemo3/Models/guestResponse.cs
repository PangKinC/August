using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo3.Models
{
    public class guestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter an e-mail address.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid e-mail address.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string phoneNo { get; set; }
        [Required(ErrorMessage = "Please choose whether you will attend the party.")]
        public bool? willAttend { get; set; }

    }
}