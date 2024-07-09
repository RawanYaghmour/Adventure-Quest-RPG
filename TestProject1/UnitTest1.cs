using Adventure_Quest_RPG;
using System.Numerics;
using System;
using System.Threading;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttackReducesEnemyHealth()
        {
            // Arrange
            var player = new Player("Hero", attackPower: 60);
            var enemy = new OrdinaryMonster("lolo", 100, 30, 20);

            // Act
            BattleSystem.Attack(player, enemy);

            // Assert
            Assert.True(enemy.Health < 100);
        }

        [Fact]
        public void EnemyAttackReducesPlayerHealth()
        {
            // Arrange
            var player = new Player("Hero", attackPower: 60);
            var enemy = new OrdinaryMonster("lolo", 100, 100, 100);

            // Act
            BattleSystem.Attack(enemy, player);

            // Assert
            Assert.True(player.Health < 200);
        }

        [Fact]
        public void WinnerHealthIsGreaterThanZeroAfterWinningBattle()
        {
            // Arrange
            var player = new Player("Hero", attackPower: 60);
            var enemy = new OrdinaryMonster("lolo", 100, 30, 20);

            // Act
            bool playerWon = BattleSystem.StartBattle(player, enemy);

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

      
        [Fact]
        public void FindCaurentLocation()
        {
            // Arrange
            var adventure = new Adventure();
            adventure.chosenLocation = "Cave";

            // Act
            string expected = "Cave";
            string result = adventure.chosenLocation;

            // Assert
            Assert.Equal(expected, result);
        }

        
        [Fact]
        public void TestBossMonster()
        {
           
            Adventure adventure = new Adventure();

            bool bossMonster = false;
            for (int i = 0; i < 100; i++)
            {
                adventure.ChooseMonster();

                if (adventure.randomMonster is BossMonster)
                {
                    bossMonster = true;
                    break;
                }
            }

            Assert.True(bossMonster, "Boss monster was never encountered in 100 attempts.");
        }
    }
    }
