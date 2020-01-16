using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Hospital
{
    public class Room
    {
        public Room()
        {
            this.Patients = new List<Patient>();
        }
        public bool isFull => this.Patients.Count == 3;
        public List<Patient> Patients { get; set; }
    }
}
