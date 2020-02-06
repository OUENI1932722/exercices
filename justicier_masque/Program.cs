using System;

namespace GJM
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidat[] justiciersMasques = InviterCandidats();

            foreach (Candidat candidat in justiciersMasques)
            {
                candidat.Afficher();
                Console.Write("Accepter le candidat ? ");
                if (Console.ReadLine().CompareTo("o") == 0)
                    candidat.Accepter();
                else
                    candidat.Refuser();
            }

            Console.WriteLine("\nLes justiciers masques ");
            foreach (Candidat candidat in justiciersMasques)
            {
                if (candidat.EstSelectionne())
                    Console.WriteLine(" > " + candidat.GetSurnom());
            }
        }

        static Candidat[] InviterCandidats()
        {
            Candidat[] candidats = new Candidat[6];

            candidats[0] = new Candidat();
            candidats[0].Initialiser("Kick-Ass", "Dave Lizewski", "Insensible à la douleur");
            candidats[1] = new Candidat();
            candidats[1].Initialiser("Hit-Girl", "Mindy Macready", "Combat en tout genre");
            candidats[2] = new Candidat();
            candidats[2].Initialiser("le colonel Stars and Stripes", "Sal Bertolinni", "Domination");
            candidats[3] = new Candidat();
            candidats[3].Initialiser("Night Bitch", "Miranda Swedlow", "Charme");
            candidats[4] = new Candidat();
            candidats[4].Initialiser("Battle Guy", "Marty Eisenberg ", "Motivation");
            candidats[5] = new Candidat();
            candidats[5].Initialiser("Ass-Kicker", "Todd Haynes ", "Aucun");

            return candidats;
        }
    }
}