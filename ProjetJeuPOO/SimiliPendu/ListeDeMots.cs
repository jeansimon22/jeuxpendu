using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    public class ListeDeMots
    {
        private List<string> listeDeMots;
        private int maxErreurs { get; set; }
        public List<string> ListeDemots { get; set; }
        public List<char> Essais { get; }
        public List<char> Erreurs { get; }
       
        public ListeDeMots()
        {
            Initialize();                    
        }
        public void Initialize()
        {
            listeDeMots = new List<string>();
            listeDeMots.Add("pomme");
            listeDeMots.Add("poire");
            listeDeMots.Add("orange");
            listeDeMots.Add("cantaloup");
            listeDeMots.Add("citron");
            listeDeMots.Add("banane");
            listeDeMots.Add("framboise");
            listeDeMots.Add("fraise");
            listeDeMots.Add("bleuet");
            listeDeMots.Add("cerise");
        }

        public string obtenirUnMoAuHazard()
        {
            Random random = new Random();
            int index = random.Next(0, listeDeMots.Count);
            string MotaTrouver = listeDeMots[index];
            
            Console.WriteLine($"Le mot à deviner contient {MotaTrouver.Length} lettres");

            return MotaTrouver;
        }         
        
    }
}