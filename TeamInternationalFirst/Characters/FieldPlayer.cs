using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst.Characters
{
    class FieldPlayer : Character
    {
        private string name;
        private double qualification;

        public FieldPlayer(double qual)
        {
            this.Name = "FieldPlayer";
            Qualification = qual;
        }


        public override string Name
        {
            get { return this.name; }
            set { this.name = value; } // I can filter the input here
        }

        public override double Qualification
        {
            get {return this.qualification; }
            set { this.qualification = value; } // I can filter the input here
        }
        public override string ToString()
        {
            return "Name: " + this.Name + " Qualification: " + this.Qualification;
        }
    }
}
