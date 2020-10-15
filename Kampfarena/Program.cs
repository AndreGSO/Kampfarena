using System;

namespace Kampfarena
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome();

            string[] allowdHeroNumbers = new string[] { "1", "2", "3" };
            int HeroNumber = GetOption(allowdHeroNumbers);

            Hero Hero;

            if (HeroNumber == 1)
            {
                Hero = new Damage();
            } else if (HeroNumber == 2)
            {
                Hero = new Healer();
            } else if (HeroNumber == 3)
            {
                Hero = new Tank();
            } else
            {
                throw new ArgumentException();
            }

            Hero.fight();
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

        
        // Mit dieser Methode kann ein UserInput validiert und in ein Int Typ umgewandelt werden
        // Das ganze wird so oft gemacht, bis der User das richtige Zeichen eingegeben hat
        // Dise können mittels des String Array Parameters übergeben werden
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
