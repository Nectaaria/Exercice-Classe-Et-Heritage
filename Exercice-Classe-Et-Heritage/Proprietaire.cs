using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Classe_Et_Heritage
{
    public class Proprietaire
    {
        string Nom;
        string Prenom;
        List<Bien> Biens;

        public Proprietaire(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Biens = new List<Bien>();
        }
        public override string ToString()
        {
            string toString = String.Format("Nom = {0}\n", this.Nom);
            toString += String.Format("Prénom = {0}\n", this.Prenom);
            return toString;
        }

    }
}
