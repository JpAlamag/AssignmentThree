using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: John Paul Alamag
 * Student Number: 300792027
 * File Name: AssignmentThree - Abstract Planets
 * Date Last Modified: 2/27/15
 * 
 */

namespace AssignmentThree___Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            TerrestrialPlanet myPlanet = new TerrestrialPlanet ("Mercury", 4990, 328.5e21, false);
            GiantPlanet myGiant = new GiantPlanet ("Uranus", 50118, 8.683e25, "Gas");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(myPlanet.ToString());
            Console.WriteLine("\n----------\n");
            Console.WriteLine(myGiant.ToString());
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
