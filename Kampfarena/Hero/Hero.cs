using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Hero
{
    class Hero
    {
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
    }
}
