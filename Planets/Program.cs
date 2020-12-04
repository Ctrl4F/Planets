using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Planets
{
    class Program
    {
        class Planets
        {
            string name;
            int mass;
            public Planets(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }
            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            PlanetName();
        }
        public static void PlanetName()
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"planets.txt";
            List<Planets> planets = new List<Planets>();
            List<string> planetlist = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            foreach(string line in planetlist)
            {
                string[] tempArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                Planets NewPlanet = new Planets(tempArray[0], Int32.Parse(tempArray[1]));
                planets.Add(NewPlanet);
                Console.WriteLine(line);
            }
            int total = 0;
            foreach(Planets planet in planets)
            {
                Console.WriteLine($"Planet: {planet.Name}; Mass: {planet.Mass}");
                total += planet.Mass;
            }
            Console.WriteLine($"Total mass: {total}");
        }
    }
}
