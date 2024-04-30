using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;
using angrybird_logic.Units;

var cli = new ConsoleInterface();

cli.Print("Angry Bird CLI testing");
cli.Print("Select Projectiles");

var bird = new Bird();
bird.Cli = cli;

var pick  = new GameAction("pick", true);
var aim   = new GameAction("aim", true);
var shoot = new GameAction("shoot", false);

pick.PrintSelectableGameAction();
aim.PrintSelectableGameAction();
shoot.PrintSelectableGameAction();

pick.GameActionDoes();

bird.IsDoingWhileShooting();
