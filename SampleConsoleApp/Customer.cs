﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Customer
    {
        public String FName { get; set; }
        public String Lname { get; set; }
        public double Salary { get; set; }
        public DateTime CreatedAt { get; set; }

        public Customer()
        {
            this.FName = "";
            this.Lname = "";
            this.Salary = 0;
            this.CreatedAt = DateTime.Now;
        }

        public Customer(string fname, string lname, double salary)
        {
            this.FName = fname;
            this.Lname = lname;
            this.Salary = salary;
            this.CreatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return String.Format("Hi from {0}, {1}", this.FName, this.Lname);

        }
    }
}
