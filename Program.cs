using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    class Program
    {

        static void Main(string[] args)

        {

            Bibliotheque bibliotheque = new Bibliotheque();

            bool quitter = false;

            while (!quitter)

            {

                AfficherMenu();

                ConsoleKeyInfo choix = Console.ReadKey();

                Console.Clear();

                switch (choix.KeyChar)

                {

                    case '1':

                        AjouterLivre(bibliotheque);

                        break;

                    case '2':

                        SupprimerLivre(bibliotheque);

                        break;

                    case '3':

                        RechercherLivre(bibliotheque);

                        break;

                    case '4':

                        EmprunterLivre(bibliotheque);

                        break;

                    case '5':

                        RetournerLivre(bibliotheque);

                        break;

                    case '6':

                        bibliotheque.AfficherLivres();

                        break;

                    case '7':

                        quitter = true;

                        Console.WriteLine("Merci d'avoir utilisé le gestionnaire de bibliothèque.");

                        break;

                    default:

                        Console.WriteLine("Choix non valide, veuillez réessayer.");

                        break;

                }

                Console.WriteLine("\nAppuyez sur une touche pour continuer...");

                Console.ReadKey();

                Console.Clear();

            }

        }

        static void AfficherMenu()

        {

            Console.WriteLine("===== Menu Bibliothèque =====");

            Console.WriteLine("1. Ajouter un livre");

            Console.WriteLine("2. Supprimer un livre");

            Console.WriteLine("3. Rechercher un livre");

            Console.WriteLine("4. Emprunter un livre");

            Console.WriteLine("5. Retourner un livre");

            Console.WriteLine("6. Afficher tous les livres");

            Console.WriteLine("7. Quitter");

            Console.WriteLine("=============================");

            Console.Write("Votre choix : ");

        }

        static void AjouterLivre(Bibliotheque bibliotheque)

        {

            Console.Write("Entrez le titre du livre : ");

            string titre = Console.ReadLine();

            Console.Write("Entrez l'auteur du livre : ");

            string auteur = Console.ReadLine();

            Livre nouveauLivre = new Livre(titre, auteur);

            bibliotheque.AjouterLivre(nouveauLivre);

        }

        static void SupprimerLivre(Bibliotheque bibliotheque)

        {

            Console.Write("Entrez le titre du livre à supprimer : ");

            string titre = Console.ReadLine();

            bibliotheque.SupprimerLivre(titre);

        }

        static void RechercherLivre(Bibliotheque bibliotheque)

        {

            Console.Write("Entrez le titre du livre à rechercher : ");

            string titre = Console.ReadLine();

            Livre livre = bibliotheque.RechercherLivre(titre);

            if (livre != null)

            {

                Console.WriteLine(livre.ToString());

            }

            else

            {

                Console.WriteLine($"Le livre '{titre}' n'a pas été trouvé.");

            }

        }

        static void EmprunterLivre(Bibliotheque bibliotheque)

        {

            Console.Write("Entrez le titre du livre à emprunter : ");

            string titre = Console.ReadLine();

            Console.Write("Entrez votre nom : ");

            string nomEmprunteur = Console.ReadLine();

            bibliotheque.EmprunterLivre(titre, nomEmprunteur);

        }

        static void RetournerLivre(Bibliotheque bibliotheque)

        {

            Console.Write("Entrez le titre du livre à retourner : ");

            string titre = Console.ReadLine();

            bibliotheque.RetournerLivre(titre);

        }
    }
}
