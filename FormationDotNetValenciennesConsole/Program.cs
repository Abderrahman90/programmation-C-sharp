using System;
using System.Linq;

namespace FormationDotNetValenciennesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region cours 1ere partie Syntaxe de base
            //Syntaxe de base du c# => ctrl + k + c => ctrl +k + u
            /*bloc comment => shift + ctrl + :
            bloc comment*/
            //Création et identification des variables
            //type de variables, primitive
            //int, long, short, byte, float,double, decimal, boolean, char,
            //Création
            //int age;
            //age = 33;
            //int age = 33;
            //bool test = false;
            //char c = 'A';
            ////Opération sur les variables
            //float a = 10;
            ////a = a + 10; <=>
            //a += 10;
            ////a++;
            ////++a;
            ////float e = a++; => e <=> 20, a <=> 21
            //float e = ++a; // => e <=> 21; a <=> 21
            //a--;
            //--a;
            //int b = 30;
            //float d = a + b;
            //Console.WriteLine(d);
            //d = a - b;
            //Console.WriteLine(d);
            //d = a * b;
            //Console.WriteLine(d);
            //d = a / b;
            //Console.WriteLine(d);
            //d = a  % b;
            //Console.WriteLine(d);
            //Console.WriteLine(c);
            //Console.WriteLine(age);
            //Console.WriteLine(test);
            //int a = 8;
            //int b = a + 10;
            //chaine de caractère
            //string chaine = "Bonjour tout le monde";
            //string chaine2 = " je suis ";
            //string nomComplet = "abadi ihab";
            //string message = chaine + chaine2 + nomComplet;
            //string nomComplet = "Abadi ihab";
            //int age = 33;
            ////string message = "Bonjour, je suis " + nomComplet; <=>
            //string message = $"Bonjour, je suis {nomComplet}, mon age est de  {age}";
            //string message2 = $"encore message 2 {message}";
            //Utilisation de la console, Instruction lecture et ecriture
            //Console.WriteLine("Une nouvelle ligne");
            //Console.Write("Nom : ");
            //Console.Write("ABADI");
            //Console.Write("Votre nom : ");
            //string nom = Console.ReadLine();
            //Console.Write("Votre âge : ");
            ////pour convertir une chaine de caractère, on peut utiliser les fonctions de la classe Convert
            //int age = Convert.ToInt32(Console.ReadLine());
            //const int taux = 5;

            //Console.WriteLine(nom + " et " + age);
            #endregion

            #region suite cours structure conditionnelle
            /*Console.Write("Merci de saisir le numéro du mois : ");
            int mois = Convert.ToInt32(Console.ReadLine());
            //if(mois == 1)
            //{
            //    Console.WriteLine("Janvier");
            //}
            //else if(mois == 2)
            //{
            //    Console.WriteLine("Février");
            //}
            ////..... => 12
            //else
            //{
            //    Console.WriteLine("Erreur de mois");
            //} <=>
            //Switch
            //switch(mois)
            //{
            //    case 1:
            //        Console.WriteLine("Janvier");
            //        break;
            //    case 2:
            //        Console.WriteLine("Février");
            //        break;
            //    //.... => 12
            //    default:
            //        Console.WriteLine("Erreur mois");
            //        break;
            //}

            //Switch avec interval
            //if(mois >= 1 && mois <= 3)
            //{
            //    Console.WriteLine("l'hiver");
            //}else if(mois >= 4 && mois <= 6)
            //{
            //    Console.WriteLine("Printemps");
            //}else if(mois >= 7 && mois <= 9)
            //{
            //    Console.WriteLine("L'été");
            //}else if(mois >= 10 && mois <= 12)
            //{
            //    Console.WriteLine("l'automne");
            //}else
            //{
            //    Console.WriteLine("Erreur mois");
            //}
            //<=>
            switch(mois)
            {
                case int n when n >= 1 && n <= 3:
                    Console.WriteLine("l'hiver");
                    break;
                case int n when n >= 4 && n <= 6:
                    Console.WriteLine("Printemps");
                    break;
                case int n when n >= 7 && n <= 9:
                    Console.WriteLine("L'été");
                    break;
                case int n when n >= 10 && n <= 12:
                    Console.WriteLine("L'automne");
                    break;
                default:
                    Console.WriteLine("Erreur mois");
                    break;
            }*/

            #endregion

            #region correction exercice 17
            //Console.WriteLine("Quelle boisson souhaitez-vous ? ");
            //Console.WriteLine("Liste des boissons disponibles : ");
            //Console.WriteLine("\t1)Eau Plate");
            //Console.WriteLine("\t2)Eau Gazeuse");
            //Console.WriteLine("\t3)Coca-cola");
            //Console.WriteLine("\t4)Fanta");
            //Console.WriteLine("\t5)Sprite");
            //Console.WriteLine("\t6)Orangina");
            //Console.WriteLine("\t7)7UP");
            //Console.Write("Faites votre choix 1 à 7 : ");
            //int choix = Convert.ToInt32(Console.ReadLine());
            //string reponse;
            //switch(choix)
            //{
            //    case 1:
            //        reponse = "eau plate";
            //        break;
            //    case 2:
            //        reponse = "eau gazeuse";
            //        break;
            //    case 3:
            //        reponse = "coca";
            //        break;
            //    case 4:
            //        reponse = "fanta";
            //        break;
            //    case 5:
            //        reponse = "sprite";
            //        break;
            //    case 6:
            //        reponse = "orangina";
            //        break;
            //    case 7:
            //        reponse = "7up";
            //        break;
            //    default:
            //        reponse = null;
            //        break;
            //}
            //if (reponse == null)
            //    Console.WriteLine("cette boisson n'existe pas");
            //else
            //    Console.WriteLine($"Votre {reponse} est servi...");
            #endregion

            #region Correction exercice 18
            /*int age;
            string reponse;
            Console.Write("Meric d'entrer l'âge de votre enfant : ");
            age = Convert.ToInt32(Console.ReadLine());
            switch(age)
            {
                case int a when a >= 3 && a <= 6:
                    reponse = "Baby";
                    break;
                case int a when a >= 7 && a <= 8:
                    reponse = "Poussin";
                    break;
                case int a when a >= 9 && a <= 10:
                    reponse = "Pupille";
                    break;
                case int a when a >= 11 && a <= 12:
                    reponse = "Minime";
                    break;
                case int a when a >= 13:
                    reponse = "Cadet";
                    break;
                default:
                    reponse = null;
                    break;
            }
            if (reponse == null)
                Console.WriteLine("Erreur d'âge");
            else
                Console.WriteLine($"Votre enfant est dans la catégorie \"{reponse}\" ! ");*/
            #endregion

            #region Cours boucle d'itération
            /*//boucle for
            //Pas de 1
            for (int i = 1; i <= 10;*//* i = i + 1 <=> i += 1 <=>*//* i++)
            {
                //instruction
                Console.WriteLine(i);
            }
            //Pas de 2
            for (int i = 1; i <= 10; i += 2)
            {
                //instruction
                Console.WriteLine(i);
            }
            *//*for(int i= 10; i>= 1; *//*i = i-1 <=> *//* i--)
            {
                Console.WriteLine(i);
            }*//*
            //Pas de 3
            for (int i = 10; i >= 1;*//* i = i - 1 <=>*//* i -= 3)
            {
                Console.WriteLine(i);
            }*/

            //Boucles imbriquées
            //for(int i=1; i <= 10; i++)
            //{
            //    for(int j=1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"Valeur de i : {i}, Valeur de j : {j}");
            //    }
            //}
            #endregion

            #region correction ex20
            //Console.WriteLine("Je commence à compter : ");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"\t {i}");
            //}
            #endregion

            #region correction ex21
            //Console.WriteLine("Table des matières : ");
            //for(int i=1; i <= 3; i++)
            //{
            //    Console.WriteLine($"\t Chapitre {i}");
            //    for(int j=1; j <= 3; j++)
            //    {
            //        Console.WriteLine($"\t\t -Partie {i}.{j}");
            //        //Console.WriteLine($"\t\t -Partie "+i+"."+j);
            //    }
            //}
            #endregion

            #region correction ex22
            //for(int i=1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Table de {i} : ");
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"\t {i} X {j} = {i * j}");
            //    }
            //}
            #endregion

            #region Correction ex23
            //double taux = 0.89;
            //double habitant = 96809;
            //const int habitantMax = 120000;
            //int annee = 0;
            //double i;
            //for (i =habitant; i <= habitantMax; i *= (1 + taux/100))
            //{
            //    annee++;
            //}
            //Console.WriteLine($"Il faudra {annee} ans, nous serons en {2015 + annee}");
            //Console.WriteLine($"Il y aura {(int)i} habitants ne {2015 + annee}");
            #endregion

            #region correction ex24
            //int nombre;
            //int calcule;
            //string chaine = "";
            //Console.Write("Merci de saisir un nombre : ");
            //nombre = Convert.ToInt32(Console.ReadLine());
            //for(int i=1; i <= (nombre / 2); i++)
            //{
            //    calcule = 0;
            //    chaine = $"{nombre} = ";
            //    for(int j=i; j<= (nombre / 2) + 1; j++)
            //    {
            //        calcule += j;
            //        chaine += $"{j}";
            //        if (calcule == nombre)
            //        {
            //            Console.WriteLine(chaine);
            //            break;
            //        }
            //        else
            //        {
            //            chaine += "+";
            //        }
            //    }

            //}
            #endregion

            #region correction ex25
            //int nombreNotes;
            //double somme = 0, min = 0, max = 0, note;
            //Console.Write("Le nombre de notes : ");
            //nombreNotes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Merci de saisir {nombreNotes} notes : ");
            //for(int i=1;i<= nombreNotes; i++)
            //{
            //    Console.Write($"\t -Merci de saisir la note {i} : ");
            //    note = Convert.ToDouble(Console.ReadLine());
            //    if(i==1)
            //    {
            //        min = note;
            //        max = note;
            //    }else
            //    {
            //        if(note > max)
            //        {
            //            max = note;
            //        }else if(note < min)
            //        {
            //            min = note;
            //        }
            //    }
            //    somme += note;
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"La meilleure note est {max}/20");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"La moins bonne note est {min}/20");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"La moyenne est de  {somme / nombreNotes}/20");
            #endregion

            #region suite cours boucle itération boucle while et do while
            /*//while
            int i = 11;
            //while(i<= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //do while
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);

            string choix;
            do
            {
                Console.WriteLine("1-- Choix 1");
                Console.WriteLine("2-- Choix 2");
                Console.WriteLine("0-- Quitter");
                choix = Console.ReadLine();
            } while (choix != "0");*/
            #endregion

            #region Correction 26
            //double taux = 0.89;
            //double habitant = 96809;
            //const int habitantMax = 120000;
            //int annee = 0;
            //while(habitant <= habitantMax)
            //{
            //    habitant *= (1 + taux / 100);
            //    annee++;
            //}
            //Console.WriteLine($"Il faudra {annee} ans, nous serons en {2015 + annee}");
            //Console.WriteLine($"Il y aura {(int)habitant} habitants ne {2015 + annee}");
            #endregion

            #region correction ex27
            //int nombre;
            //int calcule,i,j;
            //string chaine = "";
            //Console.Write("Merci de saisir un nombre : ");
            //nombre = Convert.ToInt32(Console.ReadLine());
            //i = 1;
            //while(i <= nombre/2)
            //{
            //    calcule = 0;
            //    chaine = $"{nombre} = ";
            //    j = i;
            //    while(j <= (nombre / 2) + 1)
            //    {
            //        calcule += j;
            //        chaine += $"{j}";
            //        if (calcule == nombre)
            //        {
            //            Console.WriteLine(chaine);
            //            break;
            //        }
            //        else
            //        {
            //            chaine += "+";
            //        }
            //        j++;
            //    }
            //    i++;
            //}
            #endregion

            #region correction ex28
            //int nombre, nbMystere, coups = 0;
            //Random aleatoire = new Random();
            //nbMystere = aleatoire.Next(1, 51);
            //Version do while
            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write("Veuillez saisir un nombre : ");
            //    nombre = Convert.ToInt32(Console.ReadLine());
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    if (nombre > nbMystere)
            //    {
            //        Console.WriteLine("\t le nombre lystère est plus petit");
            //    }
            //    else if(nombre < nbMystere)
            //    {
            //        Console.WriteLine("\t le nombre lystère est plus grand");
            //    }
            // coups++;
            //} while (nombre != nbMystere);

            //Version while
            //bool found = false;
            //while(found == false)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write("Veuillez saisir un nombre : ");
            //    nombre = Convert.ToInt32(Console.ReadLine());
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    if (nombre > nbMystere)
            //    {
            //        Console.WriteLine("\t le nombre lystère est plus petit");
            //        coups++;
            //    }
            //    else if (nombre < nbMystere)
            //    {
            //        Console.WriteLine("\t le nombre lystère est plus grand");
            //        coups++;
            //    }
            //    else
            //    {
            //        found = true;
            //    }
            //}


            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Bravo vous avez gagné  !!");
            //Console.WriteLine($"vous avez trouvé en {coups} coups");
            #endregion

            #region correction ex29 version while

            //double somme = 0, min = 0, max = 0, note, i=1;
            //bool stopSaisi = false;  
            //Console.WriteLine($"Merci de saisir les notes : ");
            //while(!stopSaisi)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write($"\t -Merci de saisir la note {i} : ");
            //    note = Convert.ToDouble(Console.ReadLine());
            //    if (note == 999)
            //    {
            //        stopSaisi = true;
            //    }
            //    else if(note >= 0 && note <= 20)
            //    {
            //        if (i == 1)
            //        {
            //            min = note;
            //            max = note;
            //        }
            //        else
            //        {
            //            if (note > max)
            //            {
            //                max = note;
            //            }
            //            else if (note < min)
            //            {
            //                min = note;
            //            }
            //        }
            //        somme += note;
            //        i++;
            //    } 
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\tErreur de saisie, la note est sur 20!");
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"La meilleure note est {max}/20");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"La moins bonne note est {min}/20");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"La moyenne est de  {somme / i}/20");
            #endregion

            #region correction ex29 version do while
            //double somme = 0, min = 0, max = 0, note, i = 0;
            //Console.WriteLine($"Merci de saisir les notes : ");
            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write($"\t -Merci de saisir la note {i+1} : ");
            //    note = Convert.ToDouble(Console.ReadLine());
            //    if (note == 999)
            //        break;
            //    if (note >= 0 && note <= 20)
            //    {
            //        if (i == 1)
            //        {
            //            min = note;
            //            max = note;
            //        }
            //        else
            //        {
            //            if (note > max)
            //            {
            //                max = note;
            //            }
            //            else if (note < min)
            //            {
            //                min = note;
            //            }
            //        }
            //        somme += note;
            //        i++;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\tErreur de saisie, la note est sur 20!");
            //    }
            //} while (note != 999);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"La meilleure note est {max}/20");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"La moins bonne note est {min}/20");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"La moyenne est de  {somme / i}/20, le nombre de notes {i}");
            #endregion

            #region Correction ex30 
            //string question = "Quelle est l'instruction qui permet de sortir d'une boucle en c#";
            //string reponses = "a) quit\nb) continue\nc) break \nd) exit";
            //string reponse;
            //bool win = true;
            //Console.WriteLine(question);
            //Console.WriteLine(reponses);
            //do
            //{
            //    Console.Write("Entrez votre réponse : ");
            //    reponse = Console.ReadLine();
            //    if (reponse != "c")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Incorrecte");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        string choix;
            //        do
            //        {
            //            Console.Write("Un nouvel essai ? Oui / Non : ");
            //            choix = Console.ReadLine();

            //        } while (choix != "Non" && choix != "Oui");
            //        if (choix == "Non")
            //        {
            //            win = false;
            //            break;
            //        }
            //    }

            //} while (reponse != "c");

            //if(win)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Bravo !! ");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}

            #endregion


            #region correction ex31
            //double somme=0, min=0, max=0, note, i=0;
            //string choix;
            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("1--- Saisir les notes");
            //    Console.WriteLine("2--- La plus grande note");
            //    Console.WriteLine("3--- La plus petite note");
            //    Console.WriteLine("4--- La moyenne des notes");
            //    Console.WriteLine("0--- Quitter");
            //    choix = Console.ReadLine();
            //    Console.Clear();
            //    switch(choix)
            //    {
            //        case "1":
            //            somme = 0;
            //            min = 0;
            //            max = 0;
            //            i = 0;
            //            Console.WriteLine($"Merci de saisir les notes : ");
            //            do
            //            {
            //                Console.ForegroundColor = ConsoleColor.White;
            //                Console.Write($"\t -Merci de saisir la note {i + 1} : ");
            //                note = Convert.ToDouble(Console.ReadLine());
            //                if (note == 999)
            //                    break;
            //                if (note >= 0 && note <= 20)
            //                {
            //                    if (i == 1)
            //                    {
            //                        min = note;
            //                        max = note;
            //                    }
            //                    else
            //                    {
            //                        if (note > max)
            //                        {
            //                            max = note;
            //                        }
            //                        else if (note < min)
            //                        {
            //                            min = note;
            //                        }
            //                    }
            //                    somme += note;
            //                    i++;
            //                }
            //                else
            //                {
            //                    Console.ForegroundColor = ConsoleColor.Red;
            //                    Console.WriteLine("\tErreur de saisie, la note est sur 20!");
            //                }
            //            } while (note != 999);
            //            break;
            //        case "2":
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"La meilleure note est {max}/20");
            //            break;
            //        case "3":
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine($"La moins bonne note est {min}/20");
            //            break;
            //        case "4":
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine($"La moyenne est de  {somme / i}/20, le nombre de notes {i}");
            //            break;
            //        case "0":
            //            //fermer l'application
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Erreur menu...");
            //            break;

            //    }
            //} while (choix != "0");

            #endregion

            #region Cours Tableau
            //déclarer un tableau
            /*Console.Write("Merci de saisir la taille du tableau : ");
            int taille = Convert.ToInt32(Console.ReadLine());
            int[] tableau = new int[taille];
            //Ajouter une valeur dans le tableau
            //tableau[2] = 15;
            //tableau[5] = 23;

            //Console.WriteLine(tableau[2]);
            //Console.WriteLine(tableau[1]);
            for(int i=0; i< tableau.Length; i++)
            {
                Console.Write($"Merci de saisir la valeur N° {i} : ");
                tableau[i] = Convert.ToInt32(Console.ReadLine());
            }
            //pour afficher les valeurs d'un tableau
            for(int i=0; i < tableau.Length; i++)
            {
                Console.WriteLine($"Valeur à l'index {i} : {tableau[i]}");
            }*/
            #endregion

            #region correction exercice 32
            //int[] tab = new int[10];
            //Console.WriteLine("Insertion des valeurs du tableau");
            //for(int i=0; i < tab.Length; i++)
            //{
            //    Console.Write($"Saisir la valeur {i + 1} : ");
            //    tab[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Affichage des valeurs du tableau : ");
            //string tabulation = "";
            //for(int i=0; i < tab.Length; i++)
            //{
            //    Console.WriteLine($"{tabulation}{tab[i]}");
            //    tabulation += "\t";
            //}
            #endregion

            #region correction ex33
            //char[] tab = new char[26];
            ////for(int code = 0; code < tab.Length; code++)
            ////{
            ////    tab[code] = Convert.ToChar(code + 65);
            ////}
            ////<=>
            //int index = 0;
            //for(char c = 'A'; c<='Z'; c++)
            //{
            //    //tab[index] = c;
            //    //index++;
            //    //<=>
            //    tab[index++] = c;
            //}
            //string espace = "";
            //for(int i=0; i < tab.Length; i++)
            //{
            //    Console.WriteLine(espace + tab[i]);
            //    espace += " ";
            //}
            #endregion

            #region Correction ex34
            /*Random aleatoire = new Random();
            Console.Write("Combien de nombre contiendra le tableau ? ");
            int taille = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[taille];
            for(int i=0; i < tab.Length; i++)
            {
                tab[i] = aleatoire.Next(1, 51);
            }

            Console.WriteLine("Verification des valeurs du tableau : "); 
            for(int i=0; i < tab.Length; i++)
            {
                //ternaire pour un if else                 
                string pairOuImpair = tab[i] % 2 == 0 ? "pair" : "impair";
                Console.WriteLine($"Le nombre {tab[i]} est {pairOuImpair}");
            }*/
            #endregion

            #region suite cours foreach
            //int[] tab = new int[] { 10, 20, 30 };
            //int position = 0;
            //foreach(int toto in tab)
            //{
            //    Console.WriteLine(toto);
            //    position++;
            //}
            #endregion

            #region correction ex35
            /*Console.WriteLine("======Gestion de contacts======");
            int nbContacts;
            string[] contacts;
            string choixMenu;
            Console.Write("Merci de saisir le nombre de contact : ");
            nbContacts = Convert.ToInt32(Console.ReadLine());
            contacts = new string[nbContacts];
            Console.Clear();
            do
            {
                Console.WriteLine("1--- Saisir les contacts");
                Console.WriteLine("2--- Afficher mes contacts");
                Console.Write("Faites votre choix : ");
                choixMenu = Console.ReadLine();
                Console.Clear();
                switch (choixMenu)
                {
                    case "1":
                        for (int i = 0; i < contacts.Length; i++)
                        {
                            Console.Write($"Nom et prénom du contact N° {i + 1} : ");
                            contacts[i] = Console.ReadLine();
                        }
                        break;
                    case "2":
                        for (int i = 0; i < contacts.Length; i++)
                        {
                            Console.WriteLine($"Contact N° {i + 1} : {contacts[i]}");
                        }
                        break;
                    //case "0":
                    //    Environment.Exit(0);
                    //    break;
                    default:
                        Console.WriteLine("Erreur menu");
                        break;
                }
                Console.WriteLine("Une touche pour continuer...");
                Console.ReadLine();
                Console.Clear();
            } while (choixMenu != "0");
            Environment.Exit(0);*/
            #endregion

            #region correction ex36
            //double note;
            //int nbNote;
            //double[] notes;
            //Console.Write("Combien de notes comportera le tableau : ");
            //nbNote = Convert.ToInt32(Console.ReadLine());
            //notes = new double[nbNote];
            //string choix;
            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("1--- Saisir les notes");
            //    Console.WriteLine("2--- La plus grande note");
            //    Console.WriteLine("3--- La plus petite note");
            //    Console.WriteLine("4--- La moyenne des notes");
            //    Console.WriteLine("5--- La Liste des notes");
            //    Console.WriteLine("0--- Quitter");
            //    choix = Console.ReadLine();
            //    Console.Clear();
            //    switch (choix)
            //    {
            //        case "1":
            //            Console.WriteLine($"Merci de saisir les notes : ");
            //            for(int i=0; i < notes.Length; i++)
            //            {
            //                Console.ForegroundColor = ConsoleColor.White; 
            //                do
            //                {
            //                    Console.Write($"\t -Merci de saisir la note {i + 1} : ");
            //                    note = Convert.ToDouble(Console.ReadLine());
            //                } while (note < 0 || note > 20);
            //                notes[i] = note;
            //            }
            //            break;
            //        case "2":
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"La meilleure note est {notes.Max()}/20");
            //            break;
            //        case "3":
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine($"La moins bonne note est {notes.Min()}/20");
            //            break;
            //        case "4":
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine($"La moyenne est de  {notes.Average()}/20, le nombre de notes {notes.Length}");
            //            break;
            //        case "5":
            //            for(int i=0; i < notes.Length; i++)
            //            {
            //                Console.WriteLine($"La note N° {i+1} est {notes[i]}");
            //            }
            //            break;
            //        case "0":
            //            //fermer l'application
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Erreur menu...");
            //            break;

            //    }
            //} while (choix != "0");
            #endregion
            #region correction ex37
            //string[] mois = new string[] { "Janvier", "Février", "Mars", "Avril"};
            //string tab = "";
            //foreach(string m in mois)
            //{
            //    Console.WriteLine($"{tab}{m}");
            //    tab += "\t";
            //}
            #endregion
            //pour trier un tableau, on utilisera la fonction sort des tableau
            //int[] tab = new int[] { 7, 5, 4 };
            //Array.Sort(tab);
            #region correction ex38
            /*int taille, premier, position = 0;
            Console.Write("Merci de saisir la taille du tableau : ");
            taille = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[taille];
            Random aleatoire = new Random();
            for(int i=0; i < tab.Length; i++)
            {
                tab[i] = aleatoire.Next(1, 51);
                //if(i==0)
                //{
                //    premier = tab[i];
                //}
            }
            premier = tab[0];
            Console.WriteLine("====Affichage du tableau avant tri====");
            string tabulation = "";
            foreach(int i in tab)
            {
                Console.WriteLine($"{tabulation}{i}");
                tabulation += "\t";
            }
            //tri du tableau
            Array.Sort(tab);
            Console.WriteLine("====Affichage après tri====");
            tabulation = "";
            for(int i=0; i < tab.Length; i++)
            {
                Console.WriteLine($"{tabulation}{tab[i]}");
                tabulation += "\t";
                if(tab[i] == premier)
                {
                    position = i+1;
                }
            }
            Console.WriteLine($"Le nombre {premier} se trouvait en 1ere position avant le tri, il se trouve à la position {position} après");*/
            #endregion

            #region correction TheGreat TP
            int nbPersonne, compteur = 0;
            string[] personnesRestantes;
            string[] personnesTirees;
            string choixMenu, tabulation;
            Random aleatoire = new Random();
            Console.Write("Merci de saisir le nombre de personne : ");
            nbPersonne = Convert.ToInt32(Console.ReadLine());
            personnesRestantes = new string[nbPersonne];
            personnesTirees = new string[nbPersonne];

            //Remplissage du tableau
            Console.Clear();
            for(int i=0; i < personnesRestantes.Length; i++)
            {
                Console.Write($"Merci de saisir le nom complet de la personne n° {i + 1} : ");
                personnesRestantes[i] = Console.ReadLine();
            }

            //Affichage du Menu
            do
            {
                Console.Clear();
                Console.WriteLine("1---Effectuer un tirage au sort");
                Console.WriteLine("2---Voir la liste des personnes déjà tirées");
                Console.WriteLine("3---Voir la liste des personnes restantes");
                Console.WriteLine("0---Quitter");
                Console.WriteLine("\nFaites votre choix : ");
                choixMenu = Console.ReadLine();
                switch(choixMenu)
                {
                    case "1":
                        string personneFound;
                        int nbAleatoire;
                        if(compteur < personnesRestantes.Length) 
                        {
                            do
                            {
                                nbAleatoire = aleatoire.Next(personnesRestantes.Length);
                                personneFound = personnesRestantes[nbAleatoire];
                            } while (personneFound == null);
                            personnesTirees[compteur++] = personneFound;
                            personnesRestantes[nbAleatoire] = null;
                            Console.WriteLine($"La personne tirée est {personneFound}");
                        }
                        else
                        {
                            Console.WriteLine("Plus personne à tirer au sort");
                            Console.WriteLine("Rénitialisation des tableaux");
                            compteur = 0;
                            for(int i=0; i < personnesRestantes.Length; i++)
                            {
                                personnesRestantes[i] = personnesTirees[i];
                                personnesTirees[i] = null;
                            }
                        }     
                        break;
                    case "2":
                        Console.WriteLine("==== Personnes déjà tirées ====");
                        tabulation = "";
                        foreach(string nom in personnesTirees)
                        {
                            if(nom != null)
                            {
                                Console.WriteLine(tabulation+nom);
                                tabulation += "\t";
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("==== Personnes restantes ====");
                        tabulation = "";
                        foreach (string nom in personnesRestantes)
                        {
                            if (nom != null)
                            {
                                Console.WriteLine(tabulation + nom);
                                tabulation += "\t";
                            }
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Une touche pour continuer....");
                Console.ReadLine();
            } while (choixMenu != "0");
            #endregion

        }
    }
}
