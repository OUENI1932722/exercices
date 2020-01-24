using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace energie_dorée
{
    class Program
    {
        static void Main(string[] args)
        {
            //Saisie des informations nécessaires pour la réaction
            Console.Write("Veuillez inscrire une quantité de Na  > ");
            int Na = Convert.ToInt32(Console.ReadLine());
            Console.Write("Veuillez inscrire une quantité de H2O > ");
            int H2O = Convert.ToInt32(Console.ReadLine());
            Console.Write("Veuillez inscrire une quantité de Kr  > ");
            int Kr = Convert.ToInt32(Console.ReadLine());
            //Déclaration des autres variables nécessaires pour l'expérience
            int H2 = 0;
            int OH = 0;
            int Na2 = 0;
            int KrO3H = 0;
            //Première réaction(tant que Na est plus grand/égal à 2 et que H2O est plus grand/égal à 4)
            while (Na >= 2 && H2O >= 4)
            {
                H2 += 2;
                OH += 4;
                Na2 += 2;
                Na -= 2;
                H2O -= 4;
            }
            //Affichage de la quantité des éléments générés dans la première réaction.
            Console.WriteLine("Quantités:\nNa > " + Na + " | H2O > " + H2O + " | Kr > " + Kr + " | H2 > " + H2 + " | OH > " + OH + " | Na2 > " + Na2);
            //Deuxième réaction(tant que OH est plus grand/égal à 3 et que Kr est plus grand/égal à 1)
            while (OH >= 3 && Kr >= 1)
            {
                KrO3H++;
                H2++;
                OH -= 3;
                Kr--;
            }
            //Affichage de la quantité des éléments générés dans la deuxième réaction, plus les premiers éléments.
            Console.WriteLine("KrO3H > " + KrO3H + " | H2 > " + H2 + " | OH > " + OH + " | Kr > " + Kr + " ||| Na > " + Na + " | H2O > " + H2O + " | Kr > " + Kr + " | H2 > " + H2 + " | OH > " + OH + " | Na2 > " + Na2);
            Console.ReadKey();
        }
    }
}
