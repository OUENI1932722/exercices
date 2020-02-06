using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wakanda
{
    class Program
    {
        static void Main(string[] args)
        {
            int cpt = 0;
            PanthereNoire panthere = new PanthereNoire();
            while(panthere.EstVivant())
            {
                Skrull skrull = new Skrull();
                Console.WriteLine("Un skrull attaque la Panthère Noire");
                while (skrull.EstVivant() && panthere.EstVivant())
                {
                    skrull.SubirDommage(panthere.GetDommage());
                    Console.WriteLine("         La Panthère Noire frappe le skrull.");
                    if (skrull.EstVivant() && panthere.EstVivant())
                    {
                        panthere.SubirDommage(skrull.GetDommage());
                        Console.WriteLine("         La Skrull frappe la Panthère Noire.");
                    }
                }
                cpt++;
            }
            Console.WriteLine("Le roi T'Challa a été térassé mais " + cpt + " skrulls gisent, morts, autour de lui! Le Wakanda est sauf!"); ;
            Console.ReadKey();
        }
    }
}
