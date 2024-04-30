// See https://aka.ms/new-console-template for more information


using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;

var cli = new ConsoleInterface();

cli.Print("Angry Bird CLI testing");
cli.Print("Select Projectiles");

var pick = new GAction("pick", true);
var aim = new GAction("aim", true);
var shoot = new GAction("shoot", false);

pick.PrintSelectableItem();
aim.PrintSelectableItem();
shoot.PrintSelectableItem();

pick.GActionDoes();
