using System;

namespace Kampfarena
{
    class Program
    {
        static void Main(string[] args)
        {
            welcome();
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
            
            int HeroNumber = getNumber();
            Console.Clear();
            Console.WriteLine("Deine Nummer ist: "+HeroNumber);
            
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
    }
}
