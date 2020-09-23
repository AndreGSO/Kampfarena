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
        }
    }
}
