using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Item
{
    class Item
    {
        public string name { get; set; }

        private static readonly Random random = new Random();

        protected static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        public int itemChoose()
        {
            Console.Clear();
            Console.WriteLine("Du willst ein Item benutzen? Welches soll es sein:");
            Console.WriteLine("[1] Booster - Dein nächster Schlag wird verstärkt werden.");
            Console.WriteLine("[2] Giftbombe - Du bewirfst den Gegner mit einer Giftbombe, was ihm Schaden zufügen wird.");
            // Nummer auswählen zum Int umwandeln und zurück damit
            return 0;
        }
    }
}
