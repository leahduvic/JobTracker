using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Notes { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        
        [Required]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
