using GestionBibliotheque;
using System;
using System.ComponentModel;
using System.Collections.Generic;

class Program

{

    static void Main(string[] args)

    {
        bool continuer = true;
        Bibliotheque bibliotheque = new Bibliotheque();

        while (continuer)
        {
            Console.Clear();
            Console.WriteLine("=== GESTION DE BIBLIOTHÈQUE ===");
            Console.WriteLine("1. Ajouter un livre");
            Console.WriteLine("2. Afficher tous les livres");
            Console.WriteLine("3. Rechercher un livre");
            Console.WriteLine("4. Emprunter un livre");
            Console.WriteLine("5. Retourner un livre");
            Console.WriteLine("6. Supprimer un livre");
            Console.WriteLine("0. Quitter");
            Console.Write("\nVotre choix : ");

            string? choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterLivreMenu(bibliotheque);
                    break;
                case "2":
                    AfficherLivresMenu(bibliotheque);
                    break;
                case "3":
                    RechercherLivreMenu(bibliotheque);
                    break;
                case "4":
                    EmprunterLivreMenu(bibliotheque);
                    break;
                case "5":
                    RetournerLivreMenu(bibliotheque);
                    break;
                case "6":
                    SupprimerLivreMenu(bibliotheque);
                    break;
                case "0":
                    continuer = false;
                    Console.WriteLine("Au revoir !");
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    break;
            }
        }
    }


    static void Pause()
    {
        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
        Console.ReadKey();
    }

    static void AfficherLivresMenu(Bibliotheque bibliotheque)
    {
        bibliotheque.AfficherLivres();
        Pause();
    }

    static void AjouterLivreMenu(Bibliotheque bibliotheque)
    {
        Console.Write("Entrez le nom du livre : ");
        string nom = Console.ReadLine() ?? "";
        Console.Write("Entrez l'auteur du livre : ");
        string auteur = Console.ReadLine() ?? "";
        Console.Write("Le livre est-il emprunté ? (oui/non) : ");
        string estEmprunteInput = Console.ReadLine() ?? "";
        bool estEmprunte = estEmprunteInput.Trim().ToLower() == "oui";
        Livre nouveauLivre = new Livre(nom, auteur, estEmprunte);
        string resultat = bibliotheque.AjouterLivre(nouveauLivre);
        Console.WriteLine(resultat);
        Pause();
    }

    static void RechercherLivreMenu(Bibliotheque bibliotheque)
    {
        Console.Write("Entrez le nom du livre à rechercher : ");
        string nom = Console.ReadLine() ?? "";
        bibliotheque.RechercherLivre(nom);
        Pause();
    }

    static void EmprunterLivreMenu(Bibliotheque bibliotheque)
    {
        Console.Write("Entrez le nom du livre à emprunter : ");
        string nom = Console.ReadLine() ?? "";
        Console.Write("Entrez le nom de l'emprunteur : ");
        string emprunteur = Console.ReadLine() ?? "";
        string resultat = bibliotheque.EmprunterLivre(nom, emprunteur);
        Console.WriteLine(resultat);
        Pause();
    }

    static void RetournerLivreMenu(Bibliotheque bibliotheque)
    {
        Console.Write("Entrez le nom du livre à retourner : ");
        string nom = Console.ReadLine() ?? "";
        string resultat = bibliotheque.RetournerLivre(nom);
        Console.WriteLine(resultat);
        Pause();
    }

    static void SupprimerLivreMenu(Bibliotheque bibliotheque)
    {
        Console.Write("Entrez le nom du livre à supprimer : ");
        string nom = Console.ReadLine() ?? "";
        bibliotheque.SupprimerLivre(nom);
        Console.WriteLine("Livre supprimé (si trouvé).");
        Pause();
    }



    //// Création d'une instance de la classe Bibliotheque


    //// Test de la méthode AjouterLivre

    //bibliotheque.AjouterLivre(new Livre("The Dark Forest", "Cixin Liu", false));

    //bibliotheque.AjouterLivre(new Livre("Peste", "Chuck Palahniuk", true));

    //// Affichage des livres après ajout

    //Console.WriteLine("Livres après ajout :");

    //bibliotheque.AfficherLivres();

    //// Test de la méthode RechercherLivre

    //Console.WriteLine("\nRecherche du livre 'Peste' :");

    //bibliotheque.RechercherLivre("Peste");

    //// Test de la méthode EmprunterLivre

    //Console.WriteLine("\nEmprunt du livre 'The Dark Forest' :");

    //bibliotheque.EmprunterLivre("The Dark Forest", "Amir");

    //// Affichage des livres après emprunt

    //Console.WriteLine("\nLivres après emprunt :");

    //bibliotheque.AfficherLivres();

    //// Test de la méthode RetournerLivre

    //Console.WriteLine("\nRetour du livre 'The Dark Forest' :");

    //bibliotheque.RetournerLivre("The Dark Forest");

    //// Affichage des livres après retour

    //Console.WriteLine("\nLivres après retour :");

    //bibliotheque.AfficherLivres();

    //// Test de la méthode SupprimerLivre

    //Console.WriteLine("\nSuppression du livre 'The Dark Forest' :");

    //bibliotheque.SupprimerLivre("The Dark Forest");

    //// Affichage des livres après suppression

    //Console.WriteLine("\nLivres après suppression :");

    //bibliotheque.AfficherLivres();

}