using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() { }
        public string FeathersType { get; set; }
        public string BeakType { get; set; }
        public bool Flight { get; set; }
        public string Food { get; set; }
    }
}
