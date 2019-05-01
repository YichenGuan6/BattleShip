using NUnit.Framework;
using System;

namespace MyGame
{
    [TestFixture ()]
    public class NUnitAttackResultTests
    {
        [Test ()]
        public void AttackResultToString ()
        {
            AttackResult attackResult = new AttackResult (ResultOfAttack.GameOver, "Game over", 0, 0);

            string actual = attackResult.ToString ();
            string expected = "Game over";
            Assert.AreEqual (expected, actual, "Error: AttackResultToString");
        }

        [Test ()]
        public void AttackResultToStringWithShip ()
        {
            Ship ship = new Ship (ShipName.AircraftCarrier);
            AttackResult attackResult = new AttackResult (ResultOfAttack.GameOver, ship, "Game over", 0, 0);

            string actual = attackResult.ToString ();
            string expected = "Game over " + ship.Name;

            Assert.AreEqual (expected, actual, "Error: AttackResultToStringWithShip");
        }
    }
}
