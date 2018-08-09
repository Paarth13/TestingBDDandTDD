using FluentAssertions;
using System;
using System.Reflection;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class TwoPlayerScoreSteps
    {
        private Cricket _game;
        private Cricket _game1;
        private Winner _result;
        [Given(@"Player one has started a game of cricket")]
        [When(@"Player one has started a game of cricket")]
        public void WhenPlayerOneHasStartedAGameOfCricket()
        {
            _game = new Cricket();
            
        }
        [Given(@"Player two has started a game of cricket")]
        [When(@"Player two has started a game of cricket")]
        public void WhenPlayerTwoHasStartedAGameOfCricket()
        {
            _game1 = new Cricket();
        }
        
        [Then(@"the player one and player two score should be (.*)")]
        public void ThenThePlayerOneAndPlayerTwoScoreShouldBe(int score)
        {
            _game.Score(score);
            _game1.Score(score);
        }

        [Given(@"Player one scores (.*) runs")]
        [When(@"Player one scores (.*) runs")]
        public void WhenPlayerOneScoresRuns(int score_player_one)
        {
            _game.Score(score_player_one);
        }

        [Given(@"Player two scores (.*) runs")]
        [When(@"Player two scores (.*) runs")]
        public void WhenPlayerTwoScoresRuns(int score_player_two)
        {
            _game1.Score(score_player_two);
        }

        [Then(@"Player one has scored (.*)")]
        public void ThenPlayerOneHasScored(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }

        [Then(@"Player two has scored (.*)")]
        public void ThenPlayerTwoHasScored(int score)
        {
            _game1.PlayerScore.Should().Be(score);
        }
        [Given(@"Player one gets out")]
        public void GivenPlayerOneGetsOut()
        {
            _result = new Winner();
            _game.Playing = _result.GetOut();

        }


        [Given(@"Player two gets out")]
        public void GivenPlayerTwoGetsOut()
        {
            _result = new Winner();
            _game1.Playing = _result.GetOut();
        }

        [When(@"Both get out")]
        public void WhenBothGetOut()
        {
            _game.Playing.Should().BeFalse();
            _game1.Playing.Should().BeFalse();
        }

        [Then(@"Declare the result Player two wins with (.*) runs")]
        public void ThenDeclareTheResultPlayerTwoWinsWithMoreRuns(int runs)
        {
            _result = new Winner();
            Cricket value = new Cricket();
            value=_result.DeclareWinner(_game1, _game);
            value.PlayerScore.Should().Be(runs);
        }

        [Then(@"Declare the result as tied at (.*)")]
        public void ThenDeclareTheResultAsTied(int runs)
        {
            _result = new Winner();
            Cricket value = new Cricket();
            value = _result.DeclareWinner(_game1, _game);
            value.PlayerScore.Should().Be(runs);
        }

    }
}


