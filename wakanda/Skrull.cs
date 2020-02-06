using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wakanda
{
    class Skrull
    {
        private readonly int DOMMAGE_MAXIMUM = 10;
        private readonly int POURCENTAGE_TOUCHER = 15;
        private int protection = 5, pointVie = 3;
        private Random random = new Random();

        public Skrull() { }
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
