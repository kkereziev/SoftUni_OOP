using System;
using System.Collections.Generic;
using System.Text;

namespace _01.RawData
{
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.Power = enginePower;
            this.Speed = engineSpeed;
        }
        public int Power { get; set; }
        public int Speed { get; set; }
    }
}
