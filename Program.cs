using System.IO.Pipes;
using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;
using angrybird_logic.Units;

var cli = new ConsoleInterface();

cli.Print("Angry Bird CLI testing");
cli.Print("Select Action");


List<GameAction> selectableItems = new List<GameAction>();
var pick  = new GameAction();
var aim   = new GameAction();
var shoot = new GameAction();

selectableItems.Add(pick);
selectableItems.Add(aim);
selectableItems.Add(shoot);

foreach (var gameAction in selectableItems)
{
    gameAction.IsSelectable = true;
    gameAction.PrintSelectableGameAction(gameAction.Name);
}

var myUserInput = cli.UserInput;

var selectedGameAction = new GameAction(); 
GameAction GetCurrentInput(string input) => input switch
{
    "pick" => selectedGameAction = pick,
    "aim" => selectedGameAction = aim,
    "shoot" => selectedGameAction = shoot,
    _ => throw new ArgumentOutOfRangeException("not valid"),
};

GetCurrentInput(myUserInput);
selectedGameAction.PrintSelectableGameAction(selectedGameAction.Name);
/*
void SelectGameAction(string userInput) => userInput = cli.UserInput switch
{

    _ => throw new ArgumentOutOfRangeException()
};

*/
/*
var bird = new Bird
{
    Cli = cli
};

var rock = new Rock
{
    Cli = cli
};

var bomb = new Bomb
{
    Cli = cli
};

var pig = new Pig
{
    Cli = cli,
    isHit = true
};

var wall = new Wall
{
    Cli = cli,
    isHit = false
};

var prisoner = new Prisonner
{
    Cli = cli,
    IsFree = true
};

pick.GameActionDoes();

bird.IsDoingWhileShooting();
bomb.IsDoingWhileShooting();
rock.IsDoingWhileShooting();

wall.IsDoingWhenHit();
pig.IsDoingWhenHit();

prisoner.WhatAreYouDoing();
*/