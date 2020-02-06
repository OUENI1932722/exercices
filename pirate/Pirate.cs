using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirate
{
    class Pirate
    {
        private int longueurRouteur, cpt = 0, maxEssais = 0, niveau;
        private bool alphanum;
        public Pirate(int longueurRouteur, Routeur routeur)
        {
            alphanum = routeur.GetAlphanum();
            this.longueurRouteur = longueurRouteur;
            if (alphanum)
                maxEssais = Convert.ToInt32(Math.Pow(Convert.ToDouble(36), Convert.ToDouble(longueurRouteur)));
            else
                maxEssais = Convert.ToInt32(Math.Pow(Convert.ToDouble(10), Convert.ToDouble(longueurRouteur)));
        }
        public void PiraterRouteur(Routeur routeur)
        {
            for (niveau = 1; niveau < longueurRouteur; niveau++)
            {
                char[] letters = new char[niveau];
                BruteForce(0, ref letters, routeur);
                Console.WriteLine("Changement de niveau : " + (niveau));
                if (routeur.Connection(new string(letters)))
                    niveau = longueurRouteur;
            }
            /*
            for (int nb = 0; nb < 36 && !routeur.Connection(new string(letters)); nb++)
            {
                if (alphanum)
                {
                    if (nb < 10)
                        letters[i] = Convert.ToChar(Convert.ToString(nb));
                    else
                        letters[i] = Convert.ToChar(Char.ConvertFromUtf32(nb + 55));
                }
                else
                    letters[i] = Convert.ToChar(Convert.ToString(nb));
                //BruteForce(1, ref letters, routeur);
                for (int nb2 = 0; nb2 < 36 && !routeur.Connection(new string(letters)); nb2++)
                {
                    if (alphanum)
                    {
                        if (nb2 < 10)
                            letters[i] = Convert.ToChar(Convert.ToString(nb2));
                        else
                            letters[i] = Convert.ToChar(Char.ConvertFromUtf32(nb2 + 55));
                    }
                    else
                        letters[i] = Convert.ToChar(Convert.ToString(nb2));
                }
            }
            */
        }
        private void BruteForce(int i, ref char[] letters, Routeur routeur)
        {
            if (i < niveau)
            {
                if (alphanum)
                {
                    for (int nb = 0; nb < 36 && !routeur.Connection(new string(letters)); nb++)
                    {
                        if (nb < 10)
                            letters[i] = Convert.ToChar(Convert.ToString(nb));
                        else
                            letters[i] = Convert.ToChar(Char.ConvertFromUtf32(nb + 55));
                        BruteForce(i + 1, ref letters, routeur);
                        cpt++;
                    }
                }
                else
                    for (int nb = 0; nb < 10 && !routeur.Connection(new string(letters)); nb++)
                    {
                        letters[i] = Convert.ToChar(Convert.ToString(nb));
                        BruteForce(i + 1, ref letters, routeur);
                        cpt++;
                    }
            }
        }
        public int GetNbEssais()
        {
            return cpt;
        }
        public int GetNbEssaisMax()
        {
            return maxEssais;
        }
    }
}
