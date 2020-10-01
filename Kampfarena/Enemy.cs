using System;
using System.Collections.Generic;
using System.Text;

namespace Kampfarena
{
    class Enemy
    {
        private int health = 100;
        private double enemybooster { get; set; }
        public Enemy()
        {
            this.enemybooster = 0.1;
        }
    }
}
