﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_Task2.Models
{
    public class Employee
    {

        public string FullName { get; set; }
        public string EmployeeID { get; set; }
        public decimal SIN { get; set; }
        public decimal PhoneNumber { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public string Country { get; set; }
    }
}