using NUnit.Framework;
using System;

namespace MyGame
{
    [TestFixture ()]
    public class NUnitBattleShipsGameTest
    {
        private BattleShipsGame game;
        private Player player;
        private AIHardPlayer ai;

        [SetUp ()]
        public void Setup ()
        {
            game = new BattleShipsGame ();
        }

        [Test ()]
        public void InitialisationTest ()
        {
            // arrange
            ai = new AIHardPlayer (game);

            // act
            var expected = ai.Game;
            var actual = game;

            // assert
            Assert.AreEqual (expected, actual);
        }

        [Test ()]
        public void ShouldGetShotAt ()
        {
            Assert.AreEqual ((ai.Hits * 12) - ai.Shots - (ai.PlayerGrid.ShipsKilled * 20), ai.Score);
        }

        [Test ()]
        public void ShouldReturnValues ()
        {
            Assert.AreEqual (0, ai.Hits);
            Assert.AreEqual (0, ai.Missed);
            Assert.AreEqual (0, ai.Shots);
        }
    }
}
