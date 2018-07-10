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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Date Applied")]
        public DateTime DateApplied { get; set; }

        [Display(Name = "Applied Via")]
        public string AppliedVia { get; set; }

        public bool AppSubmitted { get; set; }
        public bool ResSubmitted { get; set; }
        public bool CLSubmitted { get; set; }

        public Position Position { get; set; }
    }
}