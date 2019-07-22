using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperTrack.Web.Models
{
    public class SendEmailViewModel
    {
        [Required (ErrorMessage = "Required Field")]
        public string Location { get; set; }   
        
        [Required(ErrorMessage = "Required Field")]
        public string Doctor { get; set; }    

        [Required(ErrorMessage = "Required Field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Display(Name ="Email Address")]
        [EmailAddress (ErrorMessage = "Email Required Field")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public string  Comments { get; set; }

        
        [Required(ErrorMessage = "Required Field")]
        public bool TermsAndConditions { get; set; }

    }
    
}