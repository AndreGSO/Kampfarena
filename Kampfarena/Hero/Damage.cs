using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Hero
{
    class Damage: Hero
    {
        public Damage()
        {
            Random rnd = new Random();
            this.damage = rnd.Next(5, 10);
            this.shield = rnd.Next(3, 7);
        }
    }
}
