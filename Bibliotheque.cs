using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    public class Bibliotheque
    {

        private List<Livre> livres = new List<Livre>();

        public void AjouterLivre(Livre livre)

        {

            livres.Add(livre);

            Console.WriteLine($"Le livre '{livre.Titre}' a été ajouté à la bibliothèque.");

        }

        public void SupprimerLivre(string titre)

        {

            Livre livreASupprimer = livres.FirstOrDefault(l => l.Titre.Equals(titre, StringComparison.OrdinalIgnoreCase));

            if (livreASupprimer != null)

            {

                livres.Remove(livreASupprimer);

                Console.WriteLine($"Le livre '{titre}' a été supprimé.");

            }

            else

            {

                Console.WriteLine($"Le livre '{titre}' n'a pas été trouvé.");

            }

        }

        public Livre RechercherLivre(string titre)

        {

            return livres.FirstOrDefault(l => l.Titre.Equals(titre, StringComparison.OrdinalIgnoreCase));

        }

        public void EmprunterLivre(string titre, string nomEmprunteur)

        {

            Livre livreAEmprunter = RechercherLivre(titre);

            if (livreAEmprunter != null && livreAEmprunter.EstDisponible)

            {

                livreAEmprunter.EstDisponible = false;

                livreAEmprunter.NomEmprunteur = nomEmprunteur;

                livreAEmprunter.DateEmprunt = DateTime.Now;

                livreAEmprunter.DateRetour = DateTime.Now.AddDays(14);

                Console.WriteLine($"Le livre '{titre}' a été emprunté par {nomEmprunteur}.");

            }

            else if (livreAEmprunter != null && !livreAEmprunter.EstDisponible)

            {

                Console.WriteLine($"Le livre '{titre}' est déjà emprunté.");

            }

            else

            {

                Console.WriteLine($"Le livre '{titre}' n'a pas été trouvé.");

            }

        }

        public void RetournerLivre(string titre)

        {

            Livre livreARetourner = RechercherLivre(titre);

            if (livreARetourner != null && !livreARetourner.EstDisponible)

            {

                livreARetourner.EstDisponible = true;

                livreARetourner.NomEmprunteur = null;

                livreARetourner.DateEmprunt = null;

                livreARetourner.DateRetour = null;

                Console.WriteLine($"Le livre '{titre}' a été retourné à la bibliothèque.");

            }

            else if (livreARetourner != null && livreARetourner.EstDisponible)

            {

                Console.WriteLine($"Le livre '{titre}' n'était pas emprunté.");

            }

            else

            {

                Console.WriteLine($"Le livre '{titre}' n'a pas été trouvé.");

            }

        }

        public void AfficherLivres()

        {

            if (livres.Count > 0)

            {

                Console.WriteLine("Liste des livres dans la bibliothèque :");

                foreach (var livre in livres)

                {

                    Console.WriteLine(livre.ToString());

                }

            }

            else

            {

                Console.WriteLine("La bibliothèque est vide.");

            }

        }
    }
}
