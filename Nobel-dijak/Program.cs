using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Nobel_dijak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nobel> nobel = File.ReadAllLines("nobel.csv").Skip(1).Select(G=> new Nobel(G.Split(';'))).ToList();

            Console.WriteLine($"3. feladat: {nobel.Where(G=>G.TeljesNev == "Arthur B. McDonald").First().Tipus}");

            Console.WriteLine($"4. feladat: {nobel.Where(G=>G.Evszam == 2017 && G.Tipus == "irodalmi").First().TeljesNev}");

            Console.WriteLine("5. feladat:");
            nobel.Where(G => G.Evszam >= 1990 && G.Tipus == "béke" && G.Vezeteknev == "").ToList().ForEach(G => Console.WriteLine($"\t{G.Evszam}: {G.TeljesNev}"));

            Console.WriteLine("6. feladat:");
            nobel.Where(G => G.TeljesNev.Contains("Curie")).ToList().ForEach(G=> Console.WriteLine($"\t{G.TeljesNev}({G.Tipus})"));

            Console.WriteLine("7. feladat:");
            nobel.GroupBy(G => G.Tipus).ToList().ForEach(G => Console.WriteLine($"\t{G.Key,-25}{G.Count(),3} db"));

            File.WriteAllLines("orvosi.txt", nobel.Where(G => G.Tipus == "orvosi").Select(G => G.ToString()).ToList());
            Console.WriteLine("8. feladat: orvosi.txt");
        }
    }
}