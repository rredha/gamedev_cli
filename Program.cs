using System.IO.Pipes;
using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;
using angrybird_logic.Units;

var cli = new ConsoleInterface();

cli.Print("Angry Bird CLI testing");
cli.Print("Select Action");


var pick  = new GameAction("pick");
var aim   = new GameAction("aim");
var shoot = new GameAction("shoot");

pick.IsSelectable = true;
aim.IsSelectable = true;
shoot.IsSelectable = true;

pick.PrintSelectableGameAction();
aim.PrintSelectableGameAction();
shoot.PrintSelectableGameAction();

var myUserInput = cli.UserInput;
cli.Print(myUserInput);

GameAction selectedGameAction = new GameAction(""); 
GameAction GetCurrentInput(string input) => input switch
{
    "pick" => selectedGameAction = pick,
    "aim" => selectedGameAction = aim,
    "shoot" => selectedGameAction = shoot,
    _ => throw new ArgumentOutOfRangeException("not valid"),
};
cli.Print(GetCurrentInput(myUserInput).Name);
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