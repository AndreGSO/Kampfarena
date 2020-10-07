using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Hero
{
    class Hero
    {
        public int maxItem = 3;

        protected static readonly Random rnd = new Random();
        public int damage { get; set; }
        public int shield { get; set; }
        // Alle Helden starten immer mit 100 Lebenspunkten
        public int health = 100;

        public int getHealth()
        {
            return this.health;
        }

        public void setHealth(int health)
        {
            this.health = this.health - health;
        }

        public void fight(Hero hero)
        {
            health = hero.getHealth();
            damage = hero.damage;
            //Hier kommt der gesamte Kampfablauf rein. In einer While Schleife, solange der Held noch lebt.
            // Das ganze passiert Rundenbasiert: Man wählt aus ->
            //      Kämpfen -> Gegner schlagen
            //      Item nutzen -> Gegner vergiften ODER Krit Schlag machen
            //      Kampf Abbrechen
        }

        private void endFight(bool victory = false)
        {
            if (victory == true)
            {
                Console.Clear();
                Console.WriteLine("Du warst Siegreich und hast die Gegner besiegt!");
                Console.WriteLine("Du hast Kühne und Weisheit bewiesen, nun gehe und ruhe dich auf deinem Sieg aus!");
            } else
            {
                Console.Clear();
                Console.WriteLine("Die Gegner waren stark und ebenbürtig... Leider hat es nicht zum Sieg gereicht.");
                Console.WriteLine("Ruhe dich aus und versuche es beim nächsten mal erneut!");
            }
        }

        private void chooseOption()
        {
            Console.Clear();
            Console.WriteLine("Was ist deine nächste Aktion?");
            Console.WriteLine("[1] Gegner angreifen");
            Console.WriteLine("[2] Item benutzen");
            Console.WriteLine("[3] Fliehen");

            string[] array = {"1", "2", "3"};
            //int option = Program.getOption(array);
            return 1;
        }

        public int useItem()
        {
            //Todo: Item Verbrauch einbauen, muss immer mit dem maxItem verrechnet werden, damit man nicht unbegrenzt Items nutzen kann
            return 0;
        }
    }
}
