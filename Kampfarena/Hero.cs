using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena
{
    abstract class Hero
    {
        public int maxItem = 3;

        protected static readonly Random rnd = new Random();
        // Alle Helden starten immer mit 100 Lebenspunkten
        public int health = 100;

        private int damageFrom;
        private int damageTo;

        public Hero(int damageFrom, int damageTo)
        {
            this.damageFrom = damageFrom;
            this.damageTo = damageTo;
        }

        public int getDamage()
        {
            return rnd.Next(this.damageFrom, this.damageTo);
        }

        public int getHealth()
        {
            return this.health;
        }

        public void setHealth(int health)
        {
            this.health = this.health - health;
        }

        abstract public void fight();

        private void endFight(bool victory = false)
        {
            if (victory == true)
            {
                Console.Clear();
                Console.WriteLine("Du warst Siegreich und hast die Gegner besiegt!");
                Console.WriteLine("Du hast Kühne und Weisheit bewiesen, nun gehe und ruhe dich auf deinem Sieg aus!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Die Gegner waren stark und ebenbürtig... Leider hat es nicht zum Sieg gereicht.");
                Console.WriteLine("Ruhe dich aus und versuche es beim nächsten mal erneut!");
            }
        }

        private int chooseOption()
        {
            Console.Clear();
            Console.WriteLine("Was ist deine nächste Aktion?");
            Console.WriteLine("[1] Gegner angreifen");
            Console.WriteLine("[2] Item benutzen");
            Console.WriteLine("[3] Fliehen");

            string[] array = { "1", "2", "3" };
            int option = Program.GetOption(array);
            return option;
        }

        public int useItem()
        {
            //Todo: Item Verbrauch einbauen, muss immer mit dem maxItem verrechnet werden, damit man nicht unbegrenzt Items nutzen kann
            return 0;
        }
    }

    class Damage : Hero
    {
        public Damage() : base(5, 10)
        {
        }

        public override void fight()
        {
            int health = this.getHealth();
            bool abort = false;
            while (health > 0 && abort == false)
            {

            }
        }
    }

    class Healer : Hero
    {
        public Healer() : base(2, 7)
        {   
        }

        public override void fight()
        {
            throw new NotImplementedException();
        }
    }

    class Tank : Hero
    {
        public Tank(): base(3, 7)
        { 
        }

        public override void fight()
        {
            throw new NotImplementedException();
        }
    }
}
