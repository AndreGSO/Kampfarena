using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Hero
{
    class Healer: Hero
    {
        public Healer()
        {
            this.damage = rnd.Next(2, 7);
            this.shield = rnd.Next(3, 7);
        }
    }
}
