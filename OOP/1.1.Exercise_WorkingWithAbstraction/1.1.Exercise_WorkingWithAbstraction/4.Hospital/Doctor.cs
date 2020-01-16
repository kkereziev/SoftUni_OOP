using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Hospital
{
    public class Doctor
    {
        public Doctor(string name)
        {
            this.Name = name;
            this.Patients = new List<Patient>();
        }
        public string Name { get; private set; }
        public List<Patient> Patients { get; set; }
    }
}
