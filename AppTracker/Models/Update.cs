using System;
using System.ComponentModel.DataAnnotations;

namespace AppTracker.Models
{
    public class Update
    {
        public int UpdateID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Date Noted")]
        public DateTime Date { get; set; }

        public UpdateSubject Subject { get; set; }

        public string Note { get; set; }

        public int ApplicationID { get; set; }
        public virtual Application Application { get; set; }
    }
}