using System;
using System.Collections.Generic;
using System.Text;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
     class Menu
    {
        public void MenuPrincipal()
        {
            string menu = "";

            do
            {
                /* string nom = Console.ReadLine();
                Console.WriteLine("Veuillez entrez votre nom");
                Console.WriteLine();
                Console.ReadLine();*/

                Console.WriteLine("Veuillez choisir le jeux désirez");
                Console.WriteLine();
                Console.WriteLine("1. Bingo");
                Console.WriteLine("2. Black Jack");
                Console.WriteLine("3. Pendu");


                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        this.MenuBingo();
                        break;
                    case "2":                     
                        this.MenuBlacKJack();
                        break;
                    case "3":
                        this.JeuPendu();
                        break;
                    case "4":
                        this.Exit();
                        break;

                }

            } while (!menu.Equals("4"));
        }
        public void MenuBingo()
        {

        }
        public void MenuBlacKJack()
        {

        }
        public void JeuPendu()
        {  
            Pendu jeuPendu = new Pendu();
            jeuPendu.Jouer();
        }
        public void Exit()
        {
            Environment.Exit(1);
        }
    }
}
