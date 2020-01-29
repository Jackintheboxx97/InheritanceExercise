using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Mobility = "fly";
            IsCarnivorous = false;
            Legs = 2;
            Habitat = "Nest";
        }
        

    }
}
