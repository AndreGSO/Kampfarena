using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Item
{
    class Booster: Item
    {
        private static readonly Random random = new Random();
        public void Item(string name)
        {
            this.name = name;
        }

        public double critter()
        {
            return RandomNumberBetween(0.0, 1.0);
        }

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
