using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    public class Bibliotheque
    {
        private List<Livre> livres;


        public Bibliotheque()
        {
            livres = new List<Livre>();
        }
        public string AjouterLivre(Livre livre)
        {
            if (livre == null) return "Le livre ne peut pas être nul.";
            if (livres.Contains(livre)) return "Le livre existe déjà dans la bibliothèque.";
            livres.Add(livre);
            return "Livre ajouté avec succès.";
        }

        public void SupprimerLivre(string nom)
        {
            Livre? livreASupprimer = livres.Find(l => l.Nom.Trim() == nom.Trim());
            if (livreASupprimer != null) livres.Remove(livreASupprimer);
        }

        public void RechercherLivre(string nom)
        {
            Livre? livreTrouve = livres.Find(l => l.Nom == nom);
            if (livreTrouve != null)
            {
                Console.WriteLine($"Le livre '{livreTrouve.Nom}' a été trouvé.");
            }
            else
            {
                Console.WriteLine("Livre non trouvé.");
            }
        }
        public string EmprunterLivre(string nom, string emprunteur)
        {
            Livre livreAEmprunter = livres.Find(l => l.Nom == nom);
            if (livreAEmprunter == null) return "Livre non trouvé.";
            if (livreAEmprunter.EstEmprunte) return "Le livre est déjà emprunté.";
            livreAEmprunter.EstEmprunte = true;
            return "Livre emprunté avec succès.";
        }

        public string RetournerLivre(string nom)
        {
            Livre livreARetourner = livres.Find(l => l.Nom == nom);
            if (livreARetourner == null) return "Livre non trouvé.";
            if (!livreARetourner.EstEmprunte) return "Le livre n'est pas emprunté.";
            livreARetourner.EstEmprunte = false;
            return "Livre retourné avec succès.";
        }

        public void AfficherLivres()
        {
            foreach (Livre livre in livres)
            {
                Console.WriteLine($"Nom: {livre.Nom}, Auteur: {livre.Auteur}, Emprunté: {livre.EstEmprunte}");
            }
        }
    }
}
