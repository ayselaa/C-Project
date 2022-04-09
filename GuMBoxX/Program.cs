using GuMBoxX.Models;
using System;

namespace GuMBoxX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Press 1 - choose weopen type\n" +
                              "Press 2 - choose bullet type\n" +
                              "Press 3 - add Gadget");



            string count = Console.ReadLine();
            switch (count)
            {
                case "1":
                    Console.WriteLine("Please choose the weopen type\n" +
                        "1.Sniper\n" +
                        "2.Pistol \n" +
                        "3.AssaulRifle \n");
                    count = Console.ReadLine();
                    switch (count)
                    {
                        case "1":
                            Console.WriteLine("1.Barret MRAD \n" +
                                              "2.MK 21 \n" +
                                              "3.AWM \n");
                            count = Console.ReadLine();
                            SniperRifle assaul;
                            switch (count)
                            {
                                case "1":
                                    assaul = new SniperRifle("Barret MRAD", 20);
                                    assaul.ShowMethod();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    assaul = new SniperRifle("MK 21", 15);
                                    assaul.ShowMethod();
                                    break;

                                case "3":
                                    assaul = new SniperRifle("AWM", 10);
                                    assaul.ShowMethod();
                                    break;
                                default:
                                    break;

                            }

                            break;
                        case "2":
                            Console.WriteLine("1.SteamPunk \n" +
                                              "2.Magnum \n");
                            count = Console.ReadLine();
                            Pistol pistol;
                            switch (count)
                            {
                                case "1":
                                    pistol = new Pistol("SteamPunk", 30);
                                    pistol.ShowMethod();
                                    break;

                                case "2":
                                    pistol = new Pistol("Magnum", 30);
                                    pistol.ShowMethod();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("1.AUG \n" +
                                              "2.M416 \n");
                            count = Console.ReadLine();
                            AssaulRifle assaul1;
                            switch (count)
                            {
                                case "1":
                                    assaul1 = new AssaulRifle("AUG", 80);
                                    assaul1.ShowMethod();
                                    break;

                                case "2":
                                    assaul1 = new AssaulRifle("M416", 100);
                                    assaul1.ShowMethod();
                                    break;
                                default:
                                    break;
                            }
                            break;
                    }
                    break;
                    case "2":
                    Console.WriteLine("Please choose the bullet type" +
                               "1.For SniperRifle \n" +
                               "2.For Pistol \n" +
                               "3.For AssaulRifle \n");
                    string count1 = Console.ReadLine();
                    
                    switch (count1)
                    {
                        case "1":
                            Console.WriteLine("7.62");
                            break;
                        case "2":
                            Console.WriteLine("0.45");
                            break;
                        case "3":
                            Console.WriteLine("5.56");
                            break;


                        default: break;
                    }
                    break;
                    case "3":
                            Console.WriteLine("Please choose the Gadget \n" +
                                "1.silencer for weopen \n" +
                                "2.handle for gun \n" +
                                "3.stock for weopen \n" +
                                "4.laser for weopen \n");

                       string count2=Console.ReadLine();

                            switch (count2)
                            {
                                case "1":
                                    Console.WriteLine("1.Silencer \n" +
                                                      "2.Stock \n" +
                                                      "3.Handle \n");
                            break;

                                default:
                                    break;
                            }
                            break;
            }           
           



        }
    }
}
