using System;
using System.Collections.Generic;
using System.IO;

namespace PlanetFiles
{
    class Program
    {
        public class Planets
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
            Console.WriteLine("gg");
        }
        public static void PlanetList()
        {
            List<string> PlanetList = new List<string>();
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine("Enter a planet:");
                string planet = Console.ReadLine();
                Console.WriteLine("Mass of the planet:");
                string mass = Console.ReadLine();
                string line = $"{planet}/{mass}";
                PlanetList.Add(line);
            }
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"planets.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), PlanetList);
        }
    }
}
