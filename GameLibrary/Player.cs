using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player
    {
        private int health;

        public Player(int health)
        {
            this.health = health;
        }

        public int GetHealth()
        {
            return this.health;
        }

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public bool IsAlive()
        {
            if (this.health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
