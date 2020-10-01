using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Item
{
    class Poision: Item
    {
        public Poision()
        {
            this.name = "Giftbombe";
        }

        public int usePoision(int Herohealth)
        {
            int pois = Convert.ToInt32(RandomNumberBetween(2.0, 25.0));
            Herohealth = Herohealth - pois;
            return Herohealth;
        }
    }
}
