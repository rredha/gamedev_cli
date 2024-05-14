using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;
using angrybird_logic.Units;
using angrybird_logic.StateMachine;

var cli = new ConsoleInterface();

PromptWelcome(cli);
var state = StateMachine.State.LevelInit;
Init.cli = cli;
Init.Level();

return;

void PromptWelcome(ConsoleInterface consoleInterface)
{
    consoleInterface.Print("Angry Bird CLI testing");
    consoleInterface.Print("Select Action");
}