using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;
using angrybird_logic.Units;

var cli = new ConsoleInterface();

cli.Print("Angry Bird CLI testing");
cli.Print("Select Projectiles");

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

var pick  = new GameAction("pick", true);
var aim   = new GameAction("aim", true);
var shoot = new GameAction("shoot", false);

pick.PrintSelectableGameAction();
aim.PrintSelectableGameAction();
shoot.PrintSelectableGameAction();

pick.GameActionDoes();

bird.IsDoingWhileShooting();
bomb.IsDoingWhileShooting();
rock.IsDoingWhileShooting();

wall.IsDoingWhenHit();
pig.IsDoingWhenHit();

prisoner.WhatAreYouDoing();