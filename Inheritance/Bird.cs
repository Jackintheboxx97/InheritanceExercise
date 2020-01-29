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
        public bool HasWings { get; set; }
        public bool HasBeak { get; set; }
        public bool CanSpeakHuman { get; set; }
        public string FeatherColor { get; set; }

    }
}
