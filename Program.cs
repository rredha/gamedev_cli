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

pick.Name = "pick";
aim.Name = "aim";
shoot.Name = "shoot";

selectableItems.Add(pick);
selectableItems.Add(aim);
selectableItems.Add(shoot);

foreach (var gameAction in selectableItems)
{
    gameAction.IsSelectable = true;
    gameAction.PrintSelectableGameAction(gameAction.Name);
}

var myUserInput = cli.UserInput;

GameAction selectedGameAction; 
GameAction GetCurrentInput(string input) => input switch
{
    "pick" => selectedGameAction = pick,
    "aim" => selectedGameAction = aim,
    "shoot" => selectedGameAction = shoot,
    _ => throw new ArgumentOutOfRangeException("not valid"),
};

selectedGameAction = GetCurrentInput(myUserInput);
selectedGameAction.PrintSelectedGameAction(selectedGameAction.Name);
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