using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena.Item
{
    class Item
    {
        public string name { get; set; }

        private static readonly Random random = new Random();

        protected static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
