using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Hospital
{
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new Room[20];
        }
        public string Name { get; private set; }
        public Room[] Rooms { get; set; }
    }
}
