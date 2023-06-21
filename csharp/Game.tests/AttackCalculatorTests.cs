using System;
using Xunit;

using Game;

namespace Game.tests
{
    public class AttackCalculatorTests 
    {
        // 1. Attacker doesn't damage defender
        // 2. Attacker damages defender
        // 3. Attacker misses

        [Fact]
        public void AttackerDoesNotDamageDefender()
        {
            var uselessNumber = 0;
            var attacker = new Character(uselessNumber, uselessNumber, "A race", 1);
            var defender = new Character(22, uselessNumber, "A race", uselessNumber);
            var sut = new AttackCalculator();

            var result = sut.CalculateDamage(attacker, defender);

            Assert.Equal(0, result);
        }
        [Fact]
        public void AttackerDamagesDefender()
        {
            var uselessNumber = 0;
            var attacker = new Character(uselessNumber, uselessNumber, "A race", 1);
            var defender = new Character(22, uselessNumber, "A race", uselessNumber);
            var sut = new AttackCalculator();

            var result = sut.CalculateDamage(attacker, defender);

            Assert.Equal(0, result);
        }
    }

    public class AttackCalculatorTestable : AttackCalculator
    {
        protected override int RandomDice()
        {
            return base.RandomDice();
        }
    }


}
