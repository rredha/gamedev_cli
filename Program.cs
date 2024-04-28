// See https://aka.ms/new-console-template for more information


using angrybird_logic.ConsoleInterface;
using angrybird_logic.Action;
using Action = angrybird_logic.Action.Action;

var cli = new ConsoleInterface();

cli.Print("Angry Bird CLI testing");
cli.Print("Select Projectiles");

var pick = new Action();
var shoot = new Action();
var aim = new Action();

//CreateAction("pick");