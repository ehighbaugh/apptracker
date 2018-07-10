using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class Updates
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public UpdateSubject Subject { get; set; }
        public string Update { get; set; }

        public Application Application { get; set; }
    }
}