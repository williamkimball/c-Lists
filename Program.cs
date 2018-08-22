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

            Dictionary<string, string> Jupiter = new Dictionary<string, string> () { { "Voyager 2", "Pioneer 10" }, { "Ulysses", "Jupiter" } };

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
                string probeNameListString = string.Join (", ", probeNameList.ToArray ());
                Console.WriteLine ("{0}: {1}", planet, probeNameListString);
            }

        }
    }
}