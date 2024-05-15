using View;
using angrybird_logic.GAction;
using angrybird_logic.GameState;
using angrybird_logic.Units;

View.ConsoleView cli = new ConsoleView(); 
var myStateMachine = new GameStateMachine();
myStateMachine.
Init.cli = cli;
Init.Level();

PromptWelcome(cli);
return;

void PromptWelcome(View.ConsoleView consoleInterface)
{
    cli.Print("Angry Bird CLI testing");
    cli.Print("Select Action");
}

/*
var state = StateMachine.State.LevelInit;
Init.cli = cli;
Init.Level();

return;

void PromptWelcome(ConsoleInterface consoleInterface)
{
    consoleInterface.Print("Angry Bird CLI testing");
    consoleInterface.Print("Select Action");
}
*/