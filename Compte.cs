using System;

namespace Projet2
{
    public class Compte
    {        
        public string IdentifiantCompte { get; set; }
        public DateTime DateCreation { get; set; }

        public int MontantInitial { get; }
        public Compte()
        {
            // constructeur classe
            Console.WriteLine("Taper les 5 chiffres de ton numero de compte:");
            IdentifiantCompte = Console.ReadLine();
            DateCreation = DateTime.Now;
            Console.WriteLine("Versement initial : ");
            MontantInitial = Convert.ToInt32(Console.ReadLine());  
        }

    }


}