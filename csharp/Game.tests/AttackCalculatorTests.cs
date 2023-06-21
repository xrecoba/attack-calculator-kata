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
            var attacker = new Character(0, 0, "", 1);
            var defender = new Character(22, 0, "", 0);
            var sut = new AttackCalculator();
            var result = sut.CalculateDamage(attacker, defender);
            Assert.Equal(0, result);
        }
    }
}
