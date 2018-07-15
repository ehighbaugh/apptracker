using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppTracker.Models;

namespace AppTracker.ViewModels
{
    public class AppDetailData
    {
        public IEnumerable<Application> Applications { get; set; }
        public IEnumerable<Update> Updates { get; set; }
    }
}