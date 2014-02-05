using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter your email address")]
        [RegularExpression(@"\w+@\w+\.\w+", ErrorMessage="Please enter a valid e-mail address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("[+()-0-9]+", ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage="Please indicate whether you will attend")]
        public bool? WillAttend { get; set; }
    }
}