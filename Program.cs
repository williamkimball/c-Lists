using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> finalPlanetList = new List<string> () { "Uranus", "Neptune" };

            planetList.AddRange (finalPlanetList);

            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            planetList.Add ("Pluto");
            List<string> rockyPlanets = new List<string> ();
            rockyPlanets = planetList.GetRange (0, 4);
            planetList.Remove("Pluto");

            List<Dictionary<string, string>> probeListByPlanet = new List<Dictionary<string, string>> ();

            Dictionary<string, string> Mercury = new Dictionary<string, string> () { { "Pioneer", "Mercury" }, { "MESSENGER", "Mercury" } };

            Dictionary<string, string> Venus = new Dictionary<string, string> () { { "Venera", "Venus" }, { "IKAROS", "Venus" } };

            Dictionary<string, string> Earth = new Dictionary<string, string> () { { "HiRise", "Earth" }, { "GEOS", "Earth" } };

            Dictionary<string, string> Mars = new Dictionary<string, string> () { { "Mars Global Surveyor", "Mars" }, { "InSight", "Mars" } };

            Dictionary<string, string> Jupiter = new Dictionary<string, string> () { { "Pioneer 10", "Jupiter" }, { "Ulysses", "Jupiter" } };

            Dictionary<string, string> Saturn = new Dictionary<string, string> () { { "Cassini", "Saturn" }, { "Huygens", "Saturn" } };

            Dictionary<string, string> Neptune = new Dictionary<string, string> () { { "Voyager 1", "Neptune" }};

            Dictionary<string, string> Uranus = new Dictionary<string, string> () { { "Voyager 2", "Uranus" } };

            probeListByPlanet.Add (Mercury);
            probeListByPlanet.Add (Venus);
            probeListByPlanet.Add (Earth);
            probeListByPlanet.Add (Mars);
            probeListByPlanet.Add (Jupiter);
            probeListByPlanet.Add (Saturn);
            probeListByPlanet.Add (Neptune);
            probeListByPlanet.Add (Uranus);

            foreach (string planet in planetList) {

                List<string> probeNameList = new List<string> ();

                foreach (Dictionary<string, string> planetName in probeListByPlanet)
                    foreach (KeyValuePair<string, string> planetProbes in planetName) {
                        if (planet == planetProbes.Value) {
                            probeNameList.Add (planetProbes.Key);
                        }
                    }

                Console.WriteLine ("{0}: {1}", planet, string.Join (", ", probeNameList));
            }

        }
    }
}

// using System;
// using System.Collections.Generic;


// namespace collections
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // List of planets
//             List<string> planetList = new List<string>() { "Mercury", "Mars" };

//             // Empty list of probes
//             List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

//             // Create probe
//             Dictionary<string, string> viking = new Dictionary<string, string>() {
//                 { "Mars", "Viking" }
//             };

//             // Create probe
//             Dictionary<string, string> opportunity = new Dictionary<string, string>() {
//                 { "Mars", "Opportunity" }
//             };

//             // Create probe
//             Dictionary<string, string> mariner10 = new Dictionary<string, string>() {
//                 { "Mercury", "Mariner 10" }
//             };

//             // Add probes to the List
//             probes.Add(viking);
//             probes.Add(opportunity);
//             probes.Add(mariner10);

//             /*
//                 The planet name itself is essentially a foreign key in the probes
//                 list back to the planet list.
//                 Iterate over all the planets.
//              */
//             foreach (string planet in planetList)
//             {
//                 // Build an initial list of string to hold the matching probe names
//                 List<string> visitedProbes = new List<string>();

//                 // Iterate over all the probes
//                 foreach (Dictionary<string, string> probe in probes)
//                 {
//                     /*
//                         Does the current planet name in the dictionary match
//                         the name of the planet in the planet list
//                      */
//                     if (probe.ContainsKey(planet)) {
//                         visitedProbes.Add(probe[planet]);
//                     }

//                 }

//                 // Output the name of the planet and comma separated list of matching probes
//                 Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
//             }
//         }
//     }
// }