using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    public class Pendu : IPendu
    {
        private ListeDeMots liste;
        private List<char> listeCharJoues;
        // Les proprietes
        public ListeDeMots Liste {
            get => liste;
            set => liste = value;
        }
        public List<char> ListeCharjoues
        {
            get => listeCharJoues;
            set => listeCharJoues = value;
        }

        public Pendu()
        {
            liste = new ListeDeMots();
            listeCharJoues = new List<char>();
        }
        public int GetIndexOf(char lettre)
        {
            return 0;
        }
        // Fonction qui transforme un mot en tiret
        public string TransformerMot(string mot)
        {
            char[] tableau = mot.ToCharArray();
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = '-';
            }
            string chaine = new string(tableau);
            return chaine;
        }
        // Fonction qui permet de verifier que la lettre est presente dans le mot
        public bool VerifierLettre(string str, char lettre)
        {
            return str.Contains(lettre);
        }
        public List<int> GetListeIndice(char[] tableau,char caracter)
        {
            List<int> listeIndice = new List<int>();
            for(int indice = 0; indice< tableau.Length; indice++)
            {
                if(tableau[indice] == caracter)
                {
                    listeIndice.Add(indice);
                }
            }
            return listeIndice;
        }
     
        public void start(string motADevinner,string motCache)
        {
            string tempon = motADevinner;
            List<char> listeChars = new List<char>();
            while (VerifierLettre(motCache, '-'))
            {
                Console.WriteLine("Veuillez saisir une lettre :");
                string saisie = Console.ReadLine();
                bool Conversion = char.TryParse(saisie, out char charSaisie);
                if (Conversion == true && char.IsLetter(charSaisie))
                {
                    if (VerifierLettre(motADevinner, charSaisie))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bravo le mot contient la lettre "+ charSaisie );
                        Console.ForegroundColor = ConsoleColor.White;
                        List<int> liste = GetListeIndice(motADevinner.ToCharArray(), charSaisie);
                        int Total = liste.Count;
                        while(Total > 0)
                        {
                            int indice = liste[0];
                            motCache = InsererLettre(motCache, charSaisie, indice);
                            liste.RemoveAt(0);
                            Total--;
                        }
                        Console.WriteLine(motCache);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Le mot à deviner ne contient pas la lettre " + charSaisie);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.WriteLine("la conversion n'a pas reussie avec la lettre " + charSaisie);

                }

            }
            
        }
        // Fonction qui inserre un char dans le mot transformer en tiret
        public string InsererLettre(string str, char caractereTrouve, int position)
        {
            char[] TabChar = str.ToCharArray();
            if(TabChar[position] == '-')
            {
                TabChar[position] = caractereTrouve;
            }
            string nouvelleChaine = new string(TabChar);
            return nouvelleChaine;
        }

        public void Jouer()
        {
            string motHasard = liste.obtenirUnMoAuHazard();
            Console.WriteLine(motHasard);
            string motCache = TransformerMot(motHasard);
            Console.WriteLine(motCache);
            if (motHasard.Length < 10)
            {
                start(motHasard, motCache);

            }
                  
        }

        public void AfficherGagnant()
        {
            throw new NotImplementedException();
        }
              
    }
}

        
    
