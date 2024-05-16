using View;
using Utils;
using angrybird_logic.GameState;

var cli = new ConsoleView();

PromptWelcome(cli);
var gameStateMachine = new GameStateMachine();
gameStateMachine.SetState(new Init());
Init.cli = cli;
return;

void PromptWelcome(ConsoleView consoleInterface)
{
    consoleInterface.Print("Angry Bird CLI testing");
    consoleInterface.Print("Select Action");
}
