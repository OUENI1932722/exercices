using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reconstruction
{
    class Batiment
    {
        private string nom;
        private int nbPieces, prixConstruction, largeur, longueur;
        public enum TypeBatiment { Residentiel, Commercial, Industriel };
        private TypeBatiment typeBatiment;

        public void Initialiser(string nom, int nbPieces, int prixConstruction, int largeur, int longueur, TypeBatiment typeBatiment)
        {
            this.nom = nom;
            this.nbPieces = nbPieces;
            this.prixConstruction = prixConstruction;
            this.largeur = largeur;
            this.longueur = longueur;
            this.typeBatiment = typeBatiment;
        }
        public void Afficher()
        {
            Console.WriteLine(nom + "(" + typeBatiment + ") -> " + nbPieces + "P/" + prixConstruction + "$/" + CalculerSurface() + "m2");
        }
        public string GetNom()
        {
            return nom;
        }
        public int GetNbPieces()
        {
            return nbPieces;
        }
        public int GetPrixConstruction()
        {
            return prixConstruction;
        }
        public int GetLongueur()
        {
            return longueur;
        }
        public int GetLargeur()
        {
            return largeur;
        }
        public TypeBatiment GetTypeBatiment()
        {
            return typeBatiment;
        }
        private int CalculerSurface()
        {
            return (largeur * longueur);
        }
    }
}
