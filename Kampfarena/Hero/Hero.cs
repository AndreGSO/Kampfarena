using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Hero
{
    class Hero
    {
        public int maxItem = 3;
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
        }

        public int useItem()
        {
            //Todo: Item Verbrauch einbauen, muss immer mit dem maxItem verrechnet werden, damit man nicht unbegrenzt Items nutzen kann
            return 0;
        }
    }
}
