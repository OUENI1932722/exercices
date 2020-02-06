using System;

namespace GJM
{
    class Candidat
    {
        private string surnom, nom, pouvoir;
        private bool estAccepte;

        public void Afficher()
        {
            Console.WriteLine("Surnom        : " + surnom + "\nNom           : " + nom + "\nSuper Pouvoir : " + pouvoir);
        }

        public void Accepter()
        {
            estAccepte = true;
        }

        public void Refuser()
        {
            estAccepte = false;
        }

        public bool EstSelectionne()
        {
            if (estAccepte == true)
                return true;
            else
                return false;
        }

        public string GetSurnom()
        {
            return surnom;
        }

        public void Initialiser(string surnom, string nom, string pouvoir)
        {
            this.surnom = surnom;
            this.nom = nom;
            this.pouvoir = pouvoir;
        }
    }
}