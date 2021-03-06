﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        [Display(Name="Company")]
        public string Name { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        public string Email { get; set; }   
        public string Phone { get; set; }
        public string Website { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}