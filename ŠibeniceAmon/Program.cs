using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AnalyzaVyskytuZnaku
{

    class Program
    {
        static void Main(string[] args)
        {
            // Výpisy
            string[] vety = {   "co je septem to je s certem",
                                "blazen dava moudry bere",
                                "co muzes udelat dnes neodkladej na zitrek",
                                "co se v mladi naucis ke staru jako kdyz najdes",
                                "cin certu dobre peklem se ti odmeni"};
            

            Random rd = new Random();
            int rand_num = rd.Next(0, 4);
            int level = 0;
            string hadana_veta = vety[rand_num];
            string kodovana_veta = "";
            string pismeno = "";
            string testovana_pismena = "[abcdefghijklmnopqrstuvwxyz]";


            while (true)
            {
            //    Console.WriteLine(hadana_veta);

                kodovana_veta = Regex.Replace(hadana_veta, testovana_pismena, "*");
                Console.WriteLine(kodovana_veta);

                Console.WriteLine("Hádej písmeno: ");
                
                pismeno = Console.ReadLine();
                //Console.WriteLine(pismeno);
                
                string testovana_veta = Regex.Replace(hadana_veta, pismeno, ".");
                //Console.WriteLine(testovana_veta);
                
                if (hadana_veta.Equals(testovana_veta))
                {
                    //neuhádl jsem, kreslím oběšence
                    level = level + 1;
                } else
                {
                    //uhádl jsem kousek, vypíšu větu, kde je odkódované písmeno
                    testovana_pismena = Regex.Replace(testovana_pismena, pismeno, ""); 
                    //Console.WriteLine(testovana_pismena);

                    kodovana_veta = Regex.Replace(hadana_veta, testovana_pismena, "*");
                    Console.WriteLine(kodovana_veta);
                }
                if (hadana_veta.Equals(kodovana_veta)) {
                	Console.WriteLine("Blahopřejeme! Uhodli jste větu");
                	Console.ReadLine();
                	break;
				}
                
                switch (level)
                {
                    case 1:
                        // code block
                        Console.WriteLine(" \n" +
                  " \n" +
                  " \n" +
                  " \n" +
                  " \n" +
                  " \n" +
                  ".....................");
                        break;
                    case 2:
                        // code block
                        Console.WriteLine("   ╔\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          ".....................");
                        break;
                    case 3:
                        // code block
                        Console.WriteLine("   ╔═════\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          ".....................");
                        break;
                    case 4:
                        // code block
                        Console.WriteLine("   ╔═════+\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          "   ║\n" +
                                          ".....................");
                        break;
                    case 5:
                        // code block
                        Console.WriteLine("╔═════+\n" +
                                          "║     Q\n" +
                                          "║    \\ / \n" +
                                          "║     #\n" +
                                          "║    / \\ \n" +
                                          "║ \n" +
                                          ".....................");
                        break;
                    default:
                        // code block
                        break;
                }
                if (level > 4)
                {
                    Console.WriteLine("Prohrál jsi");
                    Console.ReadKey();
                    break;
                    
                }
                
                Console.WriteLine("Stiskni Enter a hádej dál:");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
