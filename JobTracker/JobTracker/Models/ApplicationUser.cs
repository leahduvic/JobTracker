using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(55, ErrorMessage = "Please enter your nickname")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(55, ErrorMessage = "Sorry, too long")]
        public string LastName { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

    }
}
