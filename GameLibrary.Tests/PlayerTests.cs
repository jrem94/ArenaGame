using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
using Xunit;

namespace GameLibrary.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void GetPlayerHealth()
        {
            Player player = new Player(100);

            int actual = player.GetHealth();

            Assert.Equal(100, actual);
        }

        [Fact]
        public void DamagePlayer()
        {
            Player player = new Player(100);

            player.TakeDamage(25);

            Assert.Equal(75, player.GetHealth());
        }

        [Fact]
        public void CheckPlayerAlive()
        {
            Player player = new Player(100);

            Assert.True(player.IsAlive());
        }

        [Fact]
        public void CheckPlayerDead1()
        {
            Player player = new Player(100);

            player.TakeDamage(100);

            Assert.False(player.IsAlive());
        }

        [Fact]
        public void CheckPlayerDead2()
        {
            Player player = new Player(100);

            player.TakeDamage(150);

            Assert.False(player.IsAlive());
        }
    }

    public class ItemTests
    {

    }

    public class AbilityTests
    {

    }

    public class FoeTests
    {

    }

    public class EncounterGenerator
    {

    }
}
