using System;

namespace Nobel_dijak
{
    internal class Nobel
    {
        public int Evszam { get; private set; }
        public string Tipus { get; private set; }
        public string Keresztnev { get; private set; }
        public string Vezeteknev { get; private set; }

        public Nobel(string[] adatok)
        {
            Evszam = Convert.ToInt32(adatok[0]);
            Tipus = adatok[1];
            Keresztnev = adatok[2];
            Vezeteknev = adatok[3];
        }
        public string TeljesNev { get => $"{Keresztnev} {Vezeteknev}"; }

        public override string ToString() => $"{Evszam};{TeljesNev}";
    }
}