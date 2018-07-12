using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class Update
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Date { get; set; }

        public UpdateSubject Subject { get; set; }
        public string Note { get; set; }

        public int ApplicationID { get; set; }

        public virtual Application Application { get; set; }
    }
}