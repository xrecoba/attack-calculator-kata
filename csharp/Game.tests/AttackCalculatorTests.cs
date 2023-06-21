using System;
using Xunit;

using Game;

namespace Game.tests
{
    public class AttackCalculatorTests 
    {
        
        // 4. Attacker does critical damage

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
            var damage = 1;
            var attacker = new Character(uselessNumber, damage, "A race", 1);
            var defender = new Character(0, uselessNumber, "A race", uselessNumber);
            var sut = new AttackCalculatorTestable(2);

            var result = sut.CalculateDamage(attacker, defender);

            Assert.Equal(damage, result);
        }

        [Fact]
        public void AttackerMisses()
        {
            var uselessNumber = 0;
            var damage = 1;
            var attacker = new Character(uselessNumber, damage, "A race", 1);
            var defender = new Character(0, uselessNumber, "A race", uselessNumber);
            var sut = new AttackCalculatorTestable(1);

            var result = sut.CalculateDamage(attacker, defender);

            Assert.Equal(0, result);
        }

        [Fact]
        public void AttackerInflictsCriticalDamage()
        {
            var uselessNumber = 0;
            var damage = 1;
            var attacker = new Character(uselessNumber, damage, "A race", 1);
            var defender = new Character(0, uselessNumber, "A race", uselessNumber);
            var sut = new AttackCalculatorTestable(20);

            var result = sut.CalculateDamage(attacker, defender);

            Assert.Equal(2, result);
        }
    }

    public class AttackCalculatorTestable : AttackCalculator
    {
        private int _diceResult;

        public AttackCalculatorTestable(int diceResult)
        {
            _diceResult = diceResult;
        }

        protected override int RandomDice()
        {
            return _diceResult;
        }
    }


}
