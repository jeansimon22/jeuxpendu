using System;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;
using System.Collections.Generic;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main(string[] args)
        {
            BingoController jeux1 = new BingoController();
            BlackJackController jeux2 = new BlackJackController();
             Menu appli = new Menu();
            appli.MenuPrincipal();
            Pendu pendu = new Pendu();
           
            pendu.Jouer();
        }    

    }
}
