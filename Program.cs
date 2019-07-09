using System;
using System.Collections.Generic;

namespace planet
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.   Add() Jupiter and Saturn at the end of the list.
            List<string> planet = new List<string>(){"Venus", "Mars"};
            planet.Add("Jupitor");
            //2. Create another List that contains that last two planet of our solar system.
            List<string> twoPlanets = new List<string>() { "neptune", "Uranus" };
            //3. Combine the two lists by using AddRange().
            planet.AddRange(twoPlanets);
            //4. Use Insert() to add Earth, and Venus in the correct order.
            planet.Insert(1, "earth");
            planet.Insert(0, "Mercury");
            //5. Use Add() again to add Pluto to the end of the list.
            planet.Add("Pluto");
            //6. Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a 
            List<string> rockyPlanets = planet.GetRange(0, 4);
            // rockyPlanets.ForEach(onePlanet => Console.WriteLine(onePlanet));
            //7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it 
            //from the end of planetList.
            planet.Remove("Pluto");
            planet.ForEach(singlePlanet => Console.WriteLine(singlePlanet));








        }
    }
}
