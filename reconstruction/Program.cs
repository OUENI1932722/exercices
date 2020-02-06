using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment[] rue = new Batiment[3];
            rue[0] = new Batiment();
            rue[1] = new Batiment();
            rue[2] = new Batiment();
            rue[0].Initialiser("Manoir de Hulk", 5, 200000, 50, 20, Batiment.TypeBatiment.Residentiel);
            rue[1].Initialiser("Hôtel Trivastop", 20, 1000000, 100, 40, Batiment.TypeBatiment.Commercial);
            rue[2].Initialiser("Walshop", 4, 500000, 60, 30, Batiment.TypeBatiment.Commercial);
            Batiment[] rue2 = new Batiment[2];
            rue2[0] = new Batiment();
            rue2[1] = new Batiment();
            rue2[0].Initialiser("Usine Hallcamp", 40, 3000000, 100, 100, Batiment.TypeBatiment.Industriel);
            rue2[1].Initialiser("MAX-A-101", 3, 150000, 40, 30, Batiment.TypeBatiment.Industriel);
            AfficherRue1(rue);
            AfficherRue2(rue2);
        }

        static void AfficherRue1(Batiment[] rue)
        {
            Console.WriteLine("\nAfficher rue, méthode #1");
            foreach (Batiment batiment in rue)
                batiment.Afficher();
        }
        static void AfficherRue2(Batiment[] rue)
        {
            Console.WriteLine("\nAfficher  rue, méthode #2");
            foreach (Batiment batiment in rue)
                Console.WriteLine(batiment.GetNom() + " (" + batiment.GetTypeBatiment() + ") ");
        }
    }
}
