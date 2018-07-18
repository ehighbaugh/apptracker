using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class Application
    {
        public int ID { get; set; }
        public string Position { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Date Applied")]
        public DateTime DateApplied { get; set; }

        [Display(Name = "Applied Via")]
        public string AppliedVia { get; set; }

        [Display(Name = "App")]
        public bool AppSubmitted { get; set; }

        [Display(Name = "Res")]
        public bool ResSubmitted { get; set; }

        [Display(Name = "CL")]
        public bool CLSubmitted { get; set; }

        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Update> Updates { get; set; }
    }
}