# FootballCoach
A console based American Football coaching game

The game auto generates team names. 
The user is prompted to enter a score limit that they wish to play to, between 7 and 77.

At this point, the game prompts the user to press any key to begin the game.

The console displays the current game state as follows:

**********************************************************************************************
Bears: 7        // your team score
Packers: 14     // computer team score

1st & 10        // down and distance
<= 34 yard line // side of the field and position. Player moves down the field left to right

Last play: Gain of 0 // gives the result of the last play
Rushing: 33 yards     // total rushing yards in the game
Passing: 54 yards     // total passing yards in the game

Choose a play:       // the play selection number

1) Run Middle    2) Run Off Tackle    3) Run Outside

4) Short Pass    5) Medium Pass       6) Long Pass
*********************************************************************************************

Once a play is selected, a result is generated and printed at the bottom of the screen. The results are:

1) A gain / loss of yards
2) A turnover, or turnover on downs if you don't get a first down after 4 downs
3) A touchdown

After a touchdown, turnover, or turnover on downs, the computer will get a turn if the user hasn't met the score cap.

The computer will return a result and check if their score has met the score cap. 

A win or loss is decided based on comparisions to the score cap and an appropriate message is printed based on result.
