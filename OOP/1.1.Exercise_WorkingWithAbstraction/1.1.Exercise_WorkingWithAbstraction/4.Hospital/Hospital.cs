using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Hospital
{
    public class Hospital
    {
        public Hospital()
        {
            this.Departments = new List<Department>(); 
        }
        public List<Department> Departments { get; set; }
    }
}
