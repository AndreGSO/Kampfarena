using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Item
{
    class Booster: Item
    {
        public void Item()
        {
            this.name = "Booster";
        }

        public double critter()
        {
            return RandomNumberBetween(0.0, 1.0);
        }
    }
}
