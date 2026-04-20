using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    public class Livre
    {
        public string Nom { get; set; }
        public string Auteur { get; set; } 

        public bool EstEmprunte { get; set; } = true;

        public Livre(string nom, string auteur, bool estEmprunte)
        {
            Nom = nom;
            Auteur = auteur;
            EstEmprunte = estEmprunte;
        }
    }
}
