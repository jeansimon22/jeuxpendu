using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    class BingoController
    {
        public void MenuBingox()
        {
            string BingoOptions = "";

            do
            {
                Console.WriteLine("Veuillez choisir l'une des options suivantes");
                Console.WriteLine();
                Console.WriteLine("1. Initialiser une nouvelle partie");
                Console.WriteLine("2. Visualiser une des cartes du joueur");
                Console.WriteLine("3. Visualiser la carte de l’annonceur");
                Console.WriteLine("4. Tirez une boule");
                Console.WriteLine("5. Fin de partie");

                BingoOptions = Console.ReadLine();

                switch (BingoOptions)
                {
                    case "1":
                        NouvellePartie();
                        break;
                    case "2":
                        VoirCarteJoueur();
                        break;
                    case "3":
                        CarteAnnonceur();
                        break;
                    case "4":
                        NouvelleBoulle();
                        break;
                    case "5":
                        FinPartie();
                        break;
                }

            } while (!BingoOptions.Equals("5"));         
        }
        public void NouvellePartie()
        {

        }

        public void VoirCarteJoueur()
        {

        }

        public void CarteAnnonceur()
        {

        }

        public void NouvelleBoulle()
        {

        }

        public void FinPartie()
        {
            Console.WriteLine("Voulez-vous refaire une partie (O/N)?");
            string choix = Console.ReadLine();
            switch (choix)
            {
                case "O":
                   
                    break;
                case "N":
                    
                    break;
                default:
                    Console.WriteLine("Opération invalide");
                    FinPartie();
                    break;
            }
        }
    }
}
