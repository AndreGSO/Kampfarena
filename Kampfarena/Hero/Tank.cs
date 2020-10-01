using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Hero
{
    class Tank: Hero
    {
        public Tank()
        {
            this.damage = rnd.Next(3, 7);
            this.shield = rnd.Next(5, 10);
        }
    }
}
