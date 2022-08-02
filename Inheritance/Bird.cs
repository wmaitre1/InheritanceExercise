using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public int wings { get; set; }
        public int NumberOfEgssLaid { get; set; }
        public void Chirps()
        {
            Console.WriteLine($"chirp chirp");
        }
        public bool eatsWorms { get; set; }
    }
}
