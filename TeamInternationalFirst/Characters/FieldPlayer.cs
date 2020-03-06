using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamInternationalFirst.Characters
{
    class FieldPlayer : Character
    {

        public FieldPlayer(double qual)
        {
            this.Name = "FieldPlayer";
            Qualification = qual;
        }


        public override string Name
        {
            get { return this.name; }
            protected set { this.name = value; } // I can filter the input here
        }

        public override double Qualification
        {
            get {return this.qualification; }
            protected set { this.qualification = value; } // I can filter the input here
        }
        public override string ToString()
        {
            return "Name: " + this.Name + " Qualification: " + this.Qualification;
        }
    }
}
