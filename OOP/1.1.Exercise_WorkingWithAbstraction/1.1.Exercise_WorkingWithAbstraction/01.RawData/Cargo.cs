﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.RawData
{
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.Weight = cargoWeight;
            this.Type = cargoType;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
