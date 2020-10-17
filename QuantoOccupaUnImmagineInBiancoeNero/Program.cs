using System;

namespace QuantoOccupaUnImmagineInBiancoeNero
{
    class Program
    {
        static void Main(string[] args)
        {
            double primol, secondol, biancoenero, colori256, colori65000, truecolor;
            Console.Write("inserire primo lato immagine:");
            primol = int.Parse(Console.ReadLine());
            Console.Write("inserire secondo lato immagine:");
            secondol = int.Parse(Console.ReadLine());
            biancoenero = (primol * secondol * 8) / 1024;
            colori256 = (primol * secondol) / 1024;
            colori65000 = (primol * secondol * 2) / 1024;
            truecolor = (primol * primol * 3) / 1024;
            Console.WriteLine($"/nBianco e Nero {biancoenero}KB /n" +
                $"256 colori {colori256}KB /n65000 colori {colori65000}KB /truecolor {truecolor}KB");
            Console.ReadLine();


        }
    }
}
