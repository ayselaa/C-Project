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
            Indexer<AssaulRifle> assaulRifles = new Indexer<AssaulRifle>();

            assaulRifles.CustomAdd(new AssaulRifle("Fames", 25));
            assaulRifles.CustomAdd(new AssaulRifle("M4A4", 30));
            assaulRifles.CustomAdd(new AssaulRifle("AK-47", 25));

            Indexer<Pistol> pistols = new Indexer<Pistol>();

            pistols.CustomAdd(new Pistol("Glock-18", 20));
            pistols.CustomAdd(new Pistol("P250", 40));
            pistols.CustomAdd(new Pistol("DesertEagle", 70));

            Indexer<SniperRifle> sniper = new Indexer<SniperRifle>();

            sniper.CustomAdd(new SniperRifle("Glock-18", 20));
            sniper.CustomAdd(new SniperRifle("P250", 40));
            sniper.CustomAdd(new SniperRifle("DesertEagle", 70));

            int? useGunInput = null;
            int? createGunInput = null;
            int? removeGunInput = null;
        START:
            Console.WriteLine("Press 1 - Use exist weapon\n" +
                              "Press 2 - Create new weapon\n" +
                              "Press 3 - Remove exist weapon\n" +
                              "Press 0 - Exit\n");
            Console.Write("Enter your answer: ");
            string menuIputString = Console.ReadLine();
            int menunput;
            try
            {
                menunput = Convert.ToInt32(menuIputString);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!\n" +
                                   "Please try again\n");
                goto START;
            }

            switch (menunput)
            {
                case 1:
                    Console.WriteLine("Which type gun you want to use: ");
                    Console.WriteLine("1 - Assaul Rifle\n" +
                                      "2 - Pistol\n" +
                                      "3 - Sniper\n" +
                                      "0 - Back to Menu");
                    string useGunInputString = Console.ReadLine();
                    useGunInput = Convert.ToInt32(useGunInputString);

                    switch (useGunInput)
                    {
                        case 1:
                            Console.Clear();
                            for (int i = 0; i < assaulRifles.Length; i++)
                            {
                                Console.WriteLine(assaulRifles[i].GetFullInfo());
                            }
                            Console.WriteLine("\nPress 0 for Go Back");
                            break;



                        case 2:
                            Console.Clear();
                            for (int i = 0; i < pistols.Length; i++)
                            {
                                Console.WriteLine(pistols[i].GetFullInfo());
                            }
                            Console.WriteLine("\nPress 0 for Go Back");
                            break;



                        case 3:
                            Console.Clear();
                            for (int i = 0; i < sniper.Length; i++)
                            {
                                Console.WriteLine(sniper[i].GetFullInfo());
                            }
                            Console.WriteLine("\nPress o for Go Back");
                            break;
                        case 0:
                            Console.Clear();
                            goto START;

                    }
                    break;
                case 2:
                    Console.WriteLine("Which type gun you want to use: ");
                    Console.WriteLine("1 - Assaul Rifle\n" +
                                      "2 - Pistol\n" +
                                      "3 - Sniper\n" +
                                      "0 - Back to Menu");
                    string createGunInputString = Console.ReadLine();
                    createGunInput = Convert.ToInt32(createGunInputString);
                    switch (createGunInput)
                    {
                        case 1:

                            Console.Clear();
                            Console.WriteLine("Silahin adini daxil edin:");
                            string assaultName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Silahin capacity daxil edinI:");
                            string assaulTCapacityString = Console.ReadLine();
                            int assaultCapacity = 0;

                            try
                            {
                                assaultCapacity = Convert.ToInt32(assaultCapacity);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("invalid value! \n " +
                                                  "Please Try Again!");

                            }
                            assaulRifles.CustomAdd(new AssaulRifle(assaultName, assaultCapacity));
                            goto START;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Silahin adini daxil edin:");
                            string pistolName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Silahin capacity daxil edinI:");
                            string pistolsCapacityInt = Console.ReadLine();
                            int pistolsCapacity = 0;

                            try
                            {
                                assaultCapacity = Convert.ToInt32(pistolsCapacity);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("invalid value! \n " +
                                                  "Please Try Again!");

                            }
                            assaulRifles.CustomAdd(new AssaulRifle(pistolName, pistolsCapacity));
                            goto START;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Silahin adini daxil edin:");
                            string sniperName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Silahin capacity daxil edinI:");
                            string sniperCapacityInt = Console.ReadLine();
                            int sniperCapacity = 0;

                            try
                            {
                                sniperCapacity = Convert.ToInt32(sniperCapacity);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("invalid value! \n " +
                                                  "Please Try Again!");

                            }
                            assaulRifles.CustomAdd(new AssaulRifle(sniperName, sniperCapacity));
                            goto START;
                    }
                    break;
                case 0:
                    Console.Clear();
                ERROR3:
                    Console.Write("Are you sure you want to exit?: yes, no");
                    string exitInput = Console.ReadLine();
                    if (exitInput.ToLower() == "yes")
                    {
                        goto END;
                    }
                    else if (exitInput.ToLower() == "no")
                    {
                        goto START;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!\n +" +
                            "Please Try Again!\n");

                        goto ERROR3;
                    }
                default:
                    Console.WriteLine("Invalid Input\n +" +
                        "Please Try Again!\n");

                    goto START;
            }
        END:;

        }

    }
}
