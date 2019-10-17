using System;

namespace Projet2
{
    public class Utilisateur
    {
        // variables de la classe Utilisateur
        public string Nom { get; set; } // nom utilisateur
        public string Age { get; set; } // age utilisateur
        public string Statut { get; set; } // propriétaire ou pas

        //constructeur de la classe 
        public Utilisateur()
        {
            Console.WriteLine("Votre Nom : ");
            Nom = Console.ReadLine();
            Console.WriteLine("Votre Age: Majeur ou Mineur? ");
            Age = Console.ReadLine();
            //Nom = nom;
            //Age = age;
        }

        // methode1 "AfficherDetails de l'utilisateur"
        public void AfficherDetailsUtilisateur ()
        {
            // on peut utiliser déjà la classe compte dans la classe utilisateur
            Compte compte1 = new Compte();
            String chiffresCompte = compte1.IdentifiantCompte;

            // affichage details Utilisateur avec info de son compte
            Console.WriteLine ("==== Mr " + Nom + "====");
            Console.WriteLine ("Nom : "+ Nom);
            Console.WriteLine ("Age : "+ Age);
            if (Age == "Majeur")
            {
                Statut = "Titulaire Principal";
            }
            else
            {
                Statut = "Titulaire Secondaire";
            }
            Console.WriteLine ("Statut : "+ Statut);

            Console.WriteLine ("Numero de compte : " + "BE" + chiffresCompte);
            Console.WriteLine ("Date création : " + compte1.DateCreation);
            Console.WriteLine ("Montant initial: " + compte1.MontantInitial + " euros");
        }
    }
}