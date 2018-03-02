using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Title { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Notes { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

    }
}
