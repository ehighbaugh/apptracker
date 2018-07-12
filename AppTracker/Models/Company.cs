using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        public string Email { get; set; }   
        public string Phone { get; set; }
        public string Website { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}