using System;
using System.Security.Cryptography;

namespace CharacterBuilder5e
{
    internal class Program
    {
        private const int EXIT_CHOICE = 14;
        static void Main(string[] args)
        {
            //5e Character Builder
            //Random Dice Roller: Attribute to stats. Satisfied with results? Store that info or re-roll 3x. (for loop)
            //invalid entry
            //Menus: Race, Class, Background
            //invalid entry
            //If/Else: Cleric: Weapons, Monk: Weapons. 
            //If Dex=x, then initiative=
            //Saving throws (if)
            //Skills (if) or variable? 
            //Print Character sheet

            Console.WriteLine("Welcome to Dag's Dungeons and Dragons 5e Character Generator!");
            Console.WriteLine("Please enter your hero's name:");
            string charName = Console.ReadLine();
            Console.WriteLine("Ready to roll stats? Hit enter!");
            Console.ReadLine();

            Random str = new Random();
            int strRoll = str.Next(3, 19);
            Random dex = new Random();
            int dexRoll = str.Next(3, 19);
            Random con = new Random();
            int conRoll = str.Next(3, 19);
            Random intel = new Random();
            int intRoll = str.Next(3, 19);
            Random wis = new Random();
            int wisRoll = str.Next(3, 19);
            Random cha = new Random();
            int chaRoll = str.Next(3, 19);

            Console.WriteLine("Your core roll results: ");
            Console.WriteLine($"Strength: {strRoll}\nDexterity: {dexRoll}\nConstitution: {conRoll}\nIntelligence: {intRoll}\nWisdom: {wisRoll}\nCharisma: {chaRoll}");
            Console.ReadLine();

            //Choose class or random class? (if/else)
            //Choose class
            //Valid entry
            //Confirm is correct
            //Store class

            double classChoice = 0;
            while (classChoice != EXIT_CHOICE)
            {

                ClassOptions();
                classChoice = GetValueFromUser("\nPlease enter your choice of class:");
                switch (classChoice)
                {
                    case 1:
                        Console.WriteLine($"{charName} is a Bard! Is this correct? [y/n]");
                        break;
                    case 2:
                        Console.WriteLine($"{charName} is a Barbarian! Is this correct? [y/n]");
                        break;
                    case 3:
                        Console.WriteLine($"{charName} is a Cleric! Is this correct? [y/n]");
                        break;
                    case 4:
                        Console.WriteLine($"{charName} is a Druid! Is this correct? [y/n]");
                        break;
                    case 5:
                        Console.WriteLine($"{charName} is a Fighter! Is this correct? [y/n]");
                        break;
                    case 6:
                        Console.WriteLine($"{charName} is a Monk! Is this correct? [y/n]");
                        break;
                    case 7:
                        Console.WriteLine($"{charName} is a Paladin! Is this correct? [y/n]");
                        break;
                    case 8:
                        Console.WriteLine($"{charName} is a Ranger! Is this correct? [y/n]");
                        break;
                    case 9:
                        Console.WriteLine($"{charName} is a Rogue! Is this correct? [y/n]");
                        break;
                    case 10:
                        Console.WriteLine($"{charName} is a Sorcerer! Is this correct? [y/n]");
                        break;
                    case 11:
                        Console.WriteLine($"{charName} is a Warlock! Is this correct? [y/n]");
                        break;
                    case 12:
                        Console.WriteLine($"{charName} is a Wizard! Is this correct? [y/n]");
                        break;
                    case 13:
                        Console.WriteLine($"{charName} is an Artificer! Is this correct? [y/n]");
                        break;
                    case EXIT_CHOICE:
                        Console.WriteLine("Farewell, Adventurer!");
                        break;
                    default:
                        Console.WriteLine($"That path is blocked, select a choice between 1 - {EXIT_CHOICE}.");
                        break;
                }
            }

        }
        private static void ClassOptions()
        {
            Console.WriteLine("Hero Classes:");
            Console.WriteLine("1. Bard");
            Console.WriteLine("2. Barbarian");
        }

        private static double GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            var success = Double.TryParse(Console.ReadLine(), out double result);
            while (!success)
            {
                //iterate until the user enters a number value:  
                Console.WriteLine("Please make sure to enter a valid number!");
                Console.WriteLine(message);
                var entry = Console.ReadLine();
                success = Double.TryParse(entry, out double result2);
                if (success)
                {
                    result = result2;
                }
            }

            //confirm number with user  
            Console.WriteLine($"You entered {result}.  Is this the correct number [y/n]?");
            success = Console.ReadLine().StartsWith("Y", StringComparison.OrdinalIgnoreCase);
            if (!success)
            {
                //user does not confirm, start over  
                result = GetValueFromUser(message);
            }
            return result;
        }
    }
}
