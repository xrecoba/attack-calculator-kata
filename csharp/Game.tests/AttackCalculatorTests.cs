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
            Assert.Equal(0, 0);
        }

       [Fact]
        public void ThisTestShouldFail()
        {          
            Assert.Equal(0, 42);
        }


    }
}
