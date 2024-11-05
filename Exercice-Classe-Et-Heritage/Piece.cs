using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Classe_Et_Heritage
{
    internal class Piece
    {
        int Superficie;
        string Nom;
        public Piece(int superficie, string piece)
        {
            Superficie = superficie;
            Nom = piece;
        }

        public override string ToString()
        {
            string toString = String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nom = {0}\n", this.Nom);
            return toString;
        }
    }
}
