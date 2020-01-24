using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bat_signal
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vDeplacement = new double[5] { 3, 2.5, 2, 1.5, 1 };
            double[] vDescente = new double[5] { 8.5, 5.5, 4, 2, 1.5 };
            int hauteurMin = 50;
            double hauteur = 445;
            double distance = 168;
            for (int i = 0; i < vDeplacement.Length; i++)
            {
                analyserBatParkour(vDeplacement[i], vDescente[i], distance, hauteurMin, hauteur);
            }
            Console.ReadKey();
        }
        static void analyserBatParkour(double vDeplacement, double vDescente, double distance, int hauteurMin, double hauteur)
        {
            double distanceCourante = 0;
            int duree = 0;
            Console.WriteLine("\nAnalyse de parcours\nV de déplacement > " + vDeplacement + "\nV de descente    > " + vDescente + "\nDistance         > " + distance + "\nHauteur min      > " + hauteurMin + "\nHauteur          > " + hauteur);
            while (distanceCourante < distance)
            {
                duree++;
                distanceCourante += vDeplacement;
                hauteur -= vDescente;
            }
            Console.WriteLine("RESULTATS\n--> duree    > " + duree + "\n--> distance > " + distance + "\n--> hauteur  > " + hauteur);
            if (hauteur > hauteurMin + 50)
                Console.WriteLine("Batman passe au-dessus du GCPD");
            else if (hauteur < hauteurMin)
                Console.WriteLine("Batman arrive dans le mur du GCPD");
            else
                Console.WriteLine("Batman atterri sur le toit");
        }
    }
}
