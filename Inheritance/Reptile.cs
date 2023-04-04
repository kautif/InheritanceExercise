using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() { }
        public bool Camouflage { get; set; }
        public string Motion { get; set; }
        public bool Shell { get; set; }
        public bool Poison { get; set; }

    }
}
