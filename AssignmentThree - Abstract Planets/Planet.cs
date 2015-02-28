using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree___Abstract_Planets
{
    abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
        private double _diameter;
        private double _mass;
        private string _name;
        private int _moonCount;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public double Diameter
        {
            get
            {
                return this._diameter; // read only (ro)
            }
        }
        public double Mass
        {
            get
            {
                return this._mass; // ro
            }
        }

        public string Name
        {
            get
            {
                return this._name;  // ro
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTOR ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // OVERRIDING METHOD ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public override string ToString()
        {
            return string.Format("Planet name: {0}\nDiameter: {1}\nMass: {2}", _name, _diameter, _mass);
        }

    }
}
