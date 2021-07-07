﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public class Character
    {

        public int Id { get; set; }
        public string Name { get; set; } = "Hasnian";

        public int HintPoint { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defence { get; set; } = 10;

        public int Inteligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Ali;
    }
}
