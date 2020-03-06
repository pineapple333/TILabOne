using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst.Characters
{
    class Coach : Character
    {
        private double debuff;

        public Coach()
        {
            this.Name = "Coach";
            Random rnd = new Random();
            this.Debuff = rnd.NextDouble();
        }

        public Coach(double qual)
        {
            this.Name = "Coach";
            Random rnd = new Random();
            this.Debuff = rnd.NextDouble();
            this.Qualification = qual;
        }

        public override string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }
        public override double Qualification
        {
            get { return this.qualification; }
            protected set { this.qualification = value * this.Debuff; } // I can filter the input here
        } 

        private double Debuff
        {
            get { return this.debuff; }
            set { this.debuff = value; }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " Qualification: " + this.Qualification + 
                " Debuff: " + this.Debuff;
        }
    }
}
