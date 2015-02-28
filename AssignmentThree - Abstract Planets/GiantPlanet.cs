using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree___Abstract_Planets
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private string _type;

        // CONSTRUCTOR ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }
        // PUBLIC METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public bool HasMoons()
        {
            return (MoonCount > 0 ? true : false);
        }

        public bool HasRings()
        {
            return (RingCount > 0 ? true : false);
        }
        // OVERRIDING METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public override string ToString()
        {
            return string.Format("Name: {0}\nDiameter (km): {1}\nMass (kg): {2}\nMoons: {3}\nRings: {4}", Name, Diameter, Mass, HasMoons(), HasRings());
        }
    }
}
