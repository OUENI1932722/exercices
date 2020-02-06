using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirate
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            int longueurMDP = 4;
            Routeur routeur = new Routeur(longueurMDP, true);
            Pirate pirate = new Pirate(longueurMDP, routeur);
            Console.WriteLine(routeur.GetPassword());
            var watch = System.Diagnostics.Stopwatch.StartNew();
            pirate.PiraterRouteur(routeur);
            Console.WriteLine("\nMot de passe cracké : " + routeur.GetPassword());
            Console.WriteLine("Recherche de " + pirate.GetNbEssais() + " essais sur un total possible de " + pirate.GetNbEssaisMax() + " essais.");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Temps:" + elapsedMs + "ms");
            Console.ReadKey();
        }
    }
}
