using View;
using Utils;
using angrybird_logic.GameState;

var cli = new ConsoleView();

PromptWelcome(cli);
var gameStateMachine = new GameStateMachine();
Init.cli = cli;
Init.gameStateMachine = gameStateMachine;
gameStateMachine.SetState(new Init());
return;

void PromptWelcome(ConsoleView consoleInterface)
{
    consoleInterface.Print("Angry Bird CLI testing");
    consoleInterface.Print("Select Action");
}
