﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTracker.Models
{
    public class Position
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public Company Company { get; set; }
    }
}