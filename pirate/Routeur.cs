using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirate
{
    class Routeur
    {
        private int longueur;
        private bool alphanum;
        private string password;
        public Routeur(int longueur, bool alphanum)
        {
            this.longueur = longueur;
            this.alphanum = alphanum;
            GenererPassword();
        }
        private void GenererPassword()
        {
            if (alphanum)
            {
                int nb;
                for (int i = 0; i < longueur; i++)
                {
                    nb = Program.random.Next(0, 36);
                    if (nb < 10)
                        password += nb;
                    else
                        password += Char.ConvertFromUtf32(nb + 55);
                }
            }
            else
                for (int i = 0; i < longueur; i++)
                {
                    password += Program.random.Next(0, 10);
                }
        }
        public string GetPassword()
        {
            return password;
        }
        public bool GetAlphanum()
        {
            return alphanum;
        }
        public bool Connection(string password)
        {
            if (this.password == password)
                return true;
            return false;
        }

    }
}
