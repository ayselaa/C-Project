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
                            Console.WriteLine("Please choose the bullet type" +
                                "1.For SniperRifle \n" +
                                "2=For Pistol \n" +
                                "3= For AssaulRifle \n");

                            switch (count)
                            {
                                case "1":
                                    Console.WriteLine("Bullet is 7.62 for SniperRifle");
                                    break;
                                case "2":
                                    Console.WriteLine("Bullet is 0.45 for Pistol");
                                    break;
                                case "3":
                                    Console.WriteLine("Bullet is 5.56 for AssaulRifle");
                                    break;


                                default: break;
                            }

                            break;
                        case "4":
                            Console.WriteLine("Please choose the Gadget \n" +
                                "Ə1.silencer for weopen \n" +
                                "2.handle for gun \n" +
                                "3.stock for weopen \n" +
                                "4.laser for weopen \n");
                            break;

                            switch (count)
                            {
                                case "1":
                                    Console.WriteLine("1.Silenter \n" +
                                                      "2.stock \n" +
                                                      "3.handle \n");

                                default:
                                    break;
                            }


                            break;
                default: break;
                    }
                    break;
            }


        }
    }
}
