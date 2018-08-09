using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        private Cricket _game1;


        [Given(@"Player has started a game of cricket")]
        public void WhenPlayersHasStartedAGameOfCriket()
        {
            //   ScenarioContext.Current.Pending();
            _game = new Cricket();
           
        }
        [Given(@"Player has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int score)
        {
            _game = new Cricket();
            _game.Score(score);
        }


        [When(@"Players has started a game of cricket")]
        public void WhenPlayersHasStartedAGameOfCricket()
        {
            //   ScenarioContext.Current.Pending();
            _game = new Cricket();
        }

        

        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
           
            _game.PlayerScore.Should().Be(score);
        }



        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int score)
        {
            _game.Score(score);
        }

        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.Playing = false;
        }

    }
}
