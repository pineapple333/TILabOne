using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst
{
    public abstract class Character
    {
        public abstract string Name { get; set; }
        public abstract double Qualification { get; set; }
        public abstract override string ToString();
    }
}
