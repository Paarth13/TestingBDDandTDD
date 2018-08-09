Feature: TwoPlayerScore
	In order to enjoy a game of cricket between two players
	As an audience
	I want to see what the result of the match is.

@mytag
Scenario: Player one and Player two score is zero when game starts
	When Player one has started a game of cricket
	And Player two has started a game of cricket
	Then the player one and player two score should be 0

Scenario: Player one scores runs
	Given Player one has started a game of cricket  
	When Player one scores 4 runs
	Then Player one has scored 4

Scenario: Player two scores runs
	Given Player two has started a game of cricket
	When Player two scores 6 runs
	Then Player two has scored 6

Scenario: Player one gets out after scoring some runs
	Given Player one has started a game of cricket
	Given Player one scores 3 runs
	Given Player one gets out
	When Player one scores 1 runs
	Then Player one has scored 3

Scenario: Player two gets out after scoring some runs
	Given Player two has started a game of cricket
	Given Player two scores 3 runs
	Given Player two scores 5 runs
	Given Player two gets out
	When Player two scores 1 runs
	Then Player two has scored 8

Scenario: Both the players get out and the result is decared
	Given Player two has started a game of cricket
	Given Player two scores 3 runs
	Given Player two scores 5 runs
	Given Player two gets out
	Given Player one has started a game of cricket
	Given Player one scores 3 runs
	Given Player one gets out
	When Both get out
	Then Declare the result Player two wins with 8 runs

Scenario: Both score the same runs and result is declared
	Given Player two has started a game of cricket
	Given Player two scores 3 runs
	Given Player two gets out
	Given Player one has started a game of cricket
	Given Player one scores 3 runs
	Given Player one gets out
	When Both get out
	Then Declare the result as tied at 3