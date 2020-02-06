using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace réchauffement_de
{
    class De
    {
        private int valeur, nbFaces;
        private Random rnd = new Random();

        public void Initialiser(int nbFaces)
        {
            if (nbFaces > 3 && nbFaces < 21)
                this.nbFaces = nbFaces;
            else
                this.nbFaces = 6;
        }

        public void LancerDe()
        {
            valeur = rnd.Next(1, nbFaces + 1);
        }

        public int GetValeur()
        {
            return valeur;
        }
    }
}
