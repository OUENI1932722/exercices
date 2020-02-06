using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wakanda
{
    class PanthereNoire
    {
        private readonly int DOMMAGE_MAXIMUM = 100;
        private readonly int POURCENTAGE_TOUCHER = 90;
        private int protection = 8, pointVie = 100;
        private Random random = new Random();

        public PanthereNoire() {  }
        public int GetDommage()
        {
            int dmg = random.Next(0, DOMMAGE_MAXIMUM + 1);
            if (Touche())
                return dmg;
            return 0;
        }
        public bool Touche()
        {
            if (random.Next(0, 100) < POURCENTAGE_TOUCHER)
                return true;
            return false;
        }
        public void SubirDommage(int dommageEnnemi)
        {
            if (dommageEnnemi > protection)
                pointVie -= dommageEnnemi - protection;
        }
        public bool EstVivant()
        {
            if (pointVie > 0)
                return true;
            return false;
        }
    }
}
