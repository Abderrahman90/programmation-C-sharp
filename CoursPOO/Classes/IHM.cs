using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Classes
{
    class IHM
    {
        JeuPendu jeu;
        public void Start()
        {
            Console.WriteLine("======Jeu du pendu======");
            jeu = new JeuPendu();
            jeu.GenererMasque();
            bool win = false;
            Console.WriteLine($"Voici le masque du mot à trouver : {jeu.masque}, et vous avez  {jeu.nbEssai} essais pour trouver le mot");
            do
            {
                Console.Write("Merci de saisir une lettre : ");
                char lettre = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if(jeu.TestChar(lettre))
                {
                    Console.WriteLine("Une nouvelle lettre trouvée, bravo !!!");
                }
                else
                {
                    Console.WriteLine($"Dommage, cette lettre n'existe pas il vous reste {jeu.nbEssai} essais");
                }
                Console.WriteLine(jeu.masque);
                if (jeu.TestWin())
                {
                    win = true;
                    break;
                }
            } while (jeu.nbEssai > 0);
            if(win)
            {
                Console.WriteLine("Bravo vous avez gagné !!!");
            }
            else
            {
                Console.WriteLine("Dommage, vous avez perdu !!!!");
            }
        }
    }
}
