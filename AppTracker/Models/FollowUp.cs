using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class FollowUp
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public Application Application { get; set; }
    }
}