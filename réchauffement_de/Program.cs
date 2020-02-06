using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace réchauffement_de
{
    class Program
    {
        static void Main(string[] args)
        {
            PremierJet();
            DeuxiemeJet();
            TroisiemeJet(2);
            QuatriemeJet(79);
            CinquiemeJet();
        }

        static void PremierJet()
        {
            int resultat;

            De D4 = new De();
            D4.Initialiser(4);
            D4.LancerDe();
            resultat = D4.GetValeur();
            D4.LancerDe();
            resultat += D4.GetValeur();
            resultat += 4;
            Console.WriteLine("[1] 2D4 + 4 : " + resultat);
        }

        static void DeuxiemeJet()
        {
            De D6 = new De();
            D6.Initialiser(6);
            Console.WriteLine("[2] 6 * 3D6");
            D6.LancerDe();
            Console.WriteLine("     > " + D6.GetValeur());
            D6.LancerDe();
            Console.WriteLine("     > " + D6.GetValeur());
            D6.LancerDe();
            Console.WriteLine("     > " + D6.GetValeur());
            D6.LancerDe();
            Console.WriteLine("     > " + D6.GetValeur());
            D6.LancerDe();
            Console.WriteLine("     > " + D6.GetValeur());
            D6.LancerDe();
            Console.WriteLine("     > " + D6.GetValeur());
        }

        static void TroisiemeJet(int force)
        {
            De D8 = new De();
            D8.Initialiser(8);
            D8.LancerDe();
            Console.WriteLine("[3] 1D8 + " + force + " : " + (D8.GetValeur() + force));
        }

        static void QuatriemeJet(int min)
        {
            int resultat;

            De D10 = new De();
            D10.Initialiser(10);
            D10.LancerDe();
            resultat = D10.GetValeur() * 10;
            D10.LancerDe();
            resultat += D10.GetValeur();
            if (resultat >= min)
                Console.WriteLine("[4] " + resultat + " >= " + min);
            else
                Console.WriteLine("[4] " + resultat + " <= " + min);
        }

        static void CinquiemeJet()
        {
            int compteur = 0;

            De D20 = new De();
            D20.Initialiser(20);
            D20.LancerDe();
            compteur++;
            while (D20.GetValeur() != 1 && D20.GetValeur() != 20)
            {
                D20.LancerDe();
                compteur++;
            }
            Console.WriteLine("[5] Nombre de tirs de D20 : " + compteur);
            Console.WriteLine("    > Resultat " + D20.GetValeur() + " - REUSSITE");
        }

    }
}
