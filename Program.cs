using System;

namespace Projet2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Affichage donnees utilisateur;
            Console.WriteLine("Creation Compte en cours....");
            Utilisateur utilisateur1 = new Utilisateur();
            utilisateur1.AfficherDetailsUtilisateur();
            Console.WriteLine("================");

            //retrait
            Console.WriteLine("Voulez vous faire retrait? Yes ou No");
            string reponse2 = Console.ReadLine();
            if (reponse2 == "Yes")
            {
                Console.WriteLine("Combien voulez-vous retirer?");
                int money = Convert.ToInt32(Console.ReadLine());
                Retrait retrait1 = new Retrait();
                retrait1.EffectuerRetrait(money);
            }

        }
    }
}
