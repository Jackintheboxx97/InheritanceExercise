using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class Reptile : Animal
    {  
        public Reptile()
        {
            Mobility = "sprint";
            IsCarnivorous = true;
            Legs = 4;
            Habitat = "Islands";

        }
        public string Eats { get; set; }
        public bool ColdBlooded { get; set; }
        public bool HasTail { get; set; }
        public bool EyeSlant { get; set; }

    }
}
