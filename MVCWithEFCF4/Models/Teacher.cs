﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithEFCF4.Models
{
    public class Teacher :Person
    {
        public string Subject { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }

    }
}