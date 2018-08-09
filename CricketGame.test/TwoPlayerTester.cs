using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.test
{
    [TestClass]
    public class TwoPlayerTester
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore == 3);
        }

        [TestMethod]
        public void Score_InValidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_NegativeRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(-3);
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]
        public void Declaring_The_Winner_When_GameIsTied()
        {
            var Player1 = new Cricket();
            var Player2 = new Cricket();
            int score = 3;
            Player1.Score(score);
            Player2.Score(score);
            Winner check = new Winner();
            Cricket Value = new Cricket();
            Value = check.DeclareWinner(Player1, Player2);
            Assert.AreEqual(Value.PlayerScore,score);
        }
        
        [TestMethod]
        public void Declaring_A_PlayerAWinner()
        {
            var Player1 = new Cricket();
            var Player2 = new Cricket();
            int score = 6;
            Player1.Score(4);
            Player2.Score(score);
            Winner check = new Winner();
            Cricket Value = new Cricket();
            Value = check.DeclareWinner(Player1, Player2);
            Assert.AreEqual(Value.PlayerScore, score);

        }
       
    }
}
