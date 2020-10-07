using System;
using Kampfarena.Hero;
using Kampfarena.Item;

namespace Kampfarena
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "1", "2" };
            Console.WriteLine(GetOption(array));
            
            welcome();
            int HeroNumber = getNumber();

            if (HeroNumber == 1)
            {
                Damage Hero = new Damage();
                Hero.fight(Hero);
            } else if (HeroNumber == 2)
            {
                Healer Hero = new Healer();
            } else if (HeroNumber == 3)
            {
                Tank Hero = new Tank();
            }
            
            Console.WriteLine();
        }

        static void welcome()
        {
            Console.WriteLine("Willkommen in der brutalsten commandline Kampfarena.");
            Console.WriteLine("Du hast die Wahl eine Kämpferklasse auszuwählen.");
            Console.WriteLine("Jede Klasse hat dabei seine Vor- und Nachteile.");
            Console.WriteLine("Bereit für die Auswahl? Drücke eine beliebige Taste!");
            Console.WriteLine("-----------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Du kannst zwischen folgenden Klasse auswählen:");
            Console.WriteLine("[1] DamageDealer");
            Console.WriteLine("[2] Healer");
            Console.WriteLine("[3] Tank");
            Console.WriteLine("Bitte wähle über die Nummern einer der verschiedenen Kämpfer aus!");
            Console.WriteLine("---");
        }

        static int getNumber()
        {
            int choose = 0;
            bool tester = false;

            while (tester == false)
            {
                ConsoleKeyInfo UserInput = Console.ReadKey();

                if (char.IsDigit(UserInput.KeyChar))
                {
                    choose = int.Parse(UserInput.KeyChar.ToString());
                    if ((choose == 1) || (choose == 2) || (choose == 3))
                    {
                        tester = true;
                    }
                }
            }
            return choose;
        }
        
        public static int GetOption(string[] allowedOptions)
        {
            bool valid = false;
            int counter = 0;
            while (valid == false)
            {
                if (counter > 0)
                {
                    Console.WriteLine("Ungültiges Zeichen entdeckt, bitte erneut eingeben.");
                }
                ConsoleKeyInfo UserInput = Console.ReadKey();
                foreach (string o in allowedOptions)
                {
                    if (o == UserInput.KeyChar.ToString())
                    {
                        if (char.IsDigit(UserInput.KeyChar))
                        {
                            valid = true;
                            return int.Parse(UserInput.KeyChar.ToString());
                        }
                    }
                }
                counter++;
            }
            return 0;
        }
    }
}
