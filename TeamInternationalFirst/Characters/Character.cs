using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst
{
    public abstract class Character
    {

        protected string name;
        protected double qualification;

        public abstract string Name { get; protected set; }
        public abstract double Qualification { get; protected set; }
        public abstract override string ToString();
    }
}
