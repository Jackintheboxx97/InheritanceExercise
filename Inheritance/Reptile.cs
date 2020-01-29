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

    }
}
