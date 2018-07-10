using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }   
        public string Phone { get; set; }
        public string Website { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}