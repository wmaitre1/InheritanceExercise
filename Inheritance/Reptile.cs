using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string reptileKind { get; set; }
        public string reptileName { get; set; }
        public int reptileThreatLevel { get; set; }
        public bool iSItDangerous { get; set; }
    }
}
