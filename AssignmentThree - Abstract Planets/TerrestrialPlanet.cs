using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree___Abstract_Planets
{
    class TerrestrialPlanet: Planet, IHabitable, IHasMoons
    {
        // PRIVATE INSTANCE VARIABLES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private bool _oxygen;

        // CONSTRUCTOR ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PUBLIC BOOL METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public bool Habitable()
        {
            return (this._oxygen == true ? true : false);
        }

        public bool HasMoons()
        {
            return (MoonCount > 0 ? true : false);
        }

        // OVERRIDING METHOD ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public override string ToString()
        {
            return string.Format("Name: {0}\nDiameter (km): {1}\nMass (kg): {2}\nHabitable: {3}\nMoons: {4}", Name, Diameter, Mass, _oxygen, Habitable());
        }
    }
}
