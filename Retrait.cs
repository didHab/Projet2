using System;

namespace Projet2
{
    public class Retrait
    {
        // variables de la classe Retrait
        public int MontantRetrait { get; set; }
        public int MontantRestant { get; set; }
        public DateTime HeureRetrait { get; set; }
        //constructeur
        public Retrait()
        {

        }

        public int EffectuerRetrait(int MontantRetrait)
        {
            Compte compte2 = new Compte();
            int x = compte2.MontantInitial;

            MontantRestant = x-MontantRetrait;
            Console.WriteLine(MontantRestant);
            HeureRetrait = DateTime.Now;

            Console.WriteLine("=====Recapitulatif....");
            Console.WriteLine("Retrait de " + MontantRetrait + " effectué le " + HeureRetrait);
            Console.WriteLine("Il vous reste: " + MontantRestant);
            Console.WriteLine("==========");
            return MontantRestant;
        }
    }
}