using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena
{
    //Abstraktion, Übergeordnete Klasse Hero
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

        // Abstrakte Klasse fight, wird theoretisch in allen Subklassen gebraucht, deswegen abstract
        abstract public void fight();

        // Endausgabe beim Kampf, jenachdem ob man Siegreich oder nicht ist
        protected void endFight(bool victory = false)
        {
            if (victory == true)
            {
                Console.Clear();
                Console.WriteLine("Du warst Siegreich und hast den Gegner besiegt!");
                Console.WriteLine("Du hast Kühne und Weisheit bewiesen, nun gehe und ruhe dich auf deinem Sieg aus!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Der Gegner war stark und ebenbürtig... Leider hat es nicht zum Sieg gereicht.");
                Console.WriteLine("Ruhe dich aus und versuche es beim nächsten mal erneut!");
            }
        }

        // Methode für was man als nächstes machen will
        protected int ChooseOption()
        {
            Console.Clear();
            Console.WriteLine("Was ist deine nächste Aktion?");
            Console.WriteLine("[1] Gegner angreifen");
            Console.WriteLine("[2] Fliehen");

            string[] array = { "1", "2"};
            int option = Program.GetOption(array);
            return option;
        }


        protected void Display(int ownHealth, int bossHealth)
        {
            Console.WriteLine("---");
            Console.WriteLine("Dein Leben beträgt noch: "+ ownHealth + " | Der Gegener hat noch "+ bossHealth + " Lebenspunkte übrig.");
            Console.WriteLine("Drücke eine beliebige Taste um weiter zu machen.");
            Console.WriteLine("---");
            Console.ReadKey();
        }

        protected int chooseEnemy()
        {
            Console.Clear();
            Console.WriteLine("Wähle deine Gegnerstärke aus, wähle zwischen 1 (einfach) und 5 (sehr schwer)!");

            string[] array = { "1", "2", "3", "4", "5"};
            int option = Program.GetOption(array);
            return option;
        }
    }

    class Damage : Hero
    {
        public Damage() : base(5, 9)
        {
        }

        public override void fight()
        {
            int health = this.getHealth();
            bool abort = false;
            int enemystrengt = chooseEnemy();
            Enemy boss = new Enemy(enemystrengt);
            int bosshealth = boss.getHealth();

            while (health > 0 && abort == false)
            {
                
                int choose = ChooseOption();

                // Hauptaktion, Angriff ->
                //      Der Schaden wird berechnet, Random Werte zwischen Grenzen
                //      Text wird ausgegeben, wer wie viel Schaden gemacht hat und wie viel Leben übrig bleibt
                //      Schäden werden mit Leben verrechnet
                if (choose == 1)
                {
                    // Schadensberechnung
                    int damage = this.getDamage();
                    int bossDamage = boss.getDamage();
                    // Ausgabe
                    Console.WriteLine("Du greifst den Gegener an und versachst " + damage + " Schadenspunkte!");
                    Console.WriteLine("Der Gegner greift ebenfalls an und verursacht bei dir " + bossDamage + " Schadenspunkte!");
                    Console.WriteLine("---");
                    //Boss Leben
                    bosshealth = bosshealth - damage;
                    //Spieler Leben
                    health = health - bossDamage;
                    //Anzeige
                    this.Display(health, bosshealth);
                }
                // Wenn man aus dem Kampf fliehen möchte
                if (choose == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Du konntest gerade so aus dem Kampf fliehen!");
                    abort = true;
                }
                
                // Ist der Boss besiegt, so wird der Kampf beendet
                if (bosshealth <= 0)
                {
                    endFight(true);
                    abort = true;
                }
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
            int health = this.getHealth();
            bool abort = false;
            int enemystrengt = chooseEnemy();
            Enemy boss = new Enemy(enemystrengt);
            int bosshealth = boss.getHealth();

            while (health > 0 && abort == false)
            {

                int choose = ChooseOption();

                // Hauptaktion, Angriff ->
                //      Der Schaden wird berechnet, Random Werte zwischen Grenzen
                //      Text wird ausgegeben, wer wie viel Schaden gemacht hat und wie viel Leben übrig bleibt
                //      Schäden werden mit Leben verrechnet
                if (choose == 1)
                {
                    // Schadensberechnung
                    int damage = this.getDamage();
                    int bossDamage = boss.getDamage();
                    // Ausgabe
                    Console.WriteLine("Du greifst den Gegener an und versachst " + damage + " Schadenspunkte!");
                    Console.WriteLine("Der Gegner greift ebenfalls an und verursacht bei dir " + bossDamage + " Schadenspunkte!");
                    Console.WriteLine("---");
                    //Boss Leben
                    bosshealth = bosshealth - damage;
                    //Spieler Leben
                    health = health - bossDamage;
                    //Anzeige
                    this.Display(health, bosshealth);
                }
                // Wenn man aus dem Kampf fliehen möchte
                if (choose == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Du konntest gerade so aus dem Kampf fliehen!");
                    abort = true;
                }

                // Ist der Boss besiegt, so wird der Kampf beendet
                if (bosshealth <= 0)
                {
                    endFight(true);
                    abort = true;
                }
            }
        }
    }

    class Tank : Hero
    {
        public Tank(): base(3, 7)
        { 
        }

        public override void fight()
        {
            int health = this.getHealth();
            bool abort = false;
            int enemystrengt = chooseEnemy();
            Enemy boss = new Enemy(enemystrengt);
            int bosshealth = boss.getHealth();

            while (health > 0 && abort == false)
            {

                int choose = ChooseOption();

                // Hauptaktion, Angriff ->
                //      Der Schaden wird berechnet, Random Werte zwischen Grenzen
                //      Text wird ausgegeben, wer wie viel Schaden gemacht hat und wie viel Leben übrig bleibt
                //      Schäden werden mit Leben verrechnet
                if (choose == 1)
                {
                    // Schadensberechnung
                    int damage = this.getDamage();
                    int bossDamage = boss.getDamage();
                    // Ausgabe
                    Console.WriteLine("Du greifst den Gegener an und versachst " + damage + " Schadenspunkte!");
                    Console.WriteLine("Der Gegner greift ebenfalls an und verursacht bei dir " + bossDamage + " Schadenspunkte!");
                    Console.WriteLine("---");
                    //Boss Leben
                    bosshealth = bosshealth - damage;
                    //Spieler Leben
                    health = health - bossDamage;
                    //Anzeige
                    this.Display(health, bosshealth);
                }
                // Wenn man aus dem Kampf fliehen möchte
                if (choose == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Du konntest gerade so aus dem Kampf fliehen!");
                    abort = true;
                }

                // Ist der Boss besiegt, so wird der Kampf beendet
                if (bosshealth <= 0)
                {
                    endFight(true);
                    abort = true;
                }
            }
        }
    }

    class Enemy : Hero
    {
        public int level;
        // Jenachdem was der User für ein Level angibt, ist der Gegner stärker = höheres Leben
        public Enemy(int level) : base(3,9)
        {
            this.level = level;
            this.health = this.health * level;
        }

        public override void fight()
        { 
        }
    }
}
