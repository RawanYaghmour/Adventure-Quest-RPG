using Adventure_Quest_RPG;
using System.Numerics;
using System;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttackReducesEnemyHealth()
        {
            // Arrange
            var player = new Player("Hero", attackPower: 60);
            var enemy = new GreenMonster();

            // Act
            BattleSystem.Attack(player, enemy);

            // Assert
            Assert.True(enemy.Health < 100); // Initial health of GreenMonster is 100
        }

        [Fact]
        public void EnemyAttackReducesPlayerHealth()
        {
            // Arrange
            var player = new Player("Hero", attackPower: 60);
            var enemy = new GreenMonster();

            // Act
            BattleSystem.Attack(enemy, player);

            // Assert
            Assert.True(player.Health < 100); // Initial health of Player is 100
        }

        [Fact]
        public void WinnerHealthIsGreaterThanZeroAfterWinningBattle()
        {
            // Arrange
            var player = new Player("Hero", attackPower: 60);
            var enemy = new GreenMonster();

            // Act
            bool playerWon = BattleSystem.StartStartBattle(player, enemy);

            // Assert
            if (playerWon)
            {
                Assert.True(player.Health > 0);
            }
            else
            {
                Assert.True(enemy.Health > 0);
            }
        }
    }
}