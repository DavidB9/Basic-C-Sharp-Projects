using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalFeatures
{
    public class Player
    {
        public int playerHealth { get; set; }
        public string playerName { get; set; }

        public Player(string name) : this(name, 100)
        {

        }

        public Player(string name, int health)
        {
            playerHealth = health;
            playerName = name;
        }
    }
}
