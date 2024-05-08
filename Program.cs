using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;
using angrybird_logic.Units;
using angrybird_logic.StateMachine;

var cli = new ConsoleInterface();

PromptWelcome(cli);
var state = StateMachine.State.LevelInit;
Init.cli = cli;
Init.Level();


/*
bird.IsDoingWhileShooting();
bomb.IsDoingWhileShooting();
rock.IsDoingWhileShooting();

wall.IsDoingWhenHit();
pig.IsDoingWhenHit();

prisoner.WhatAreYouDoing();
*/

//SpawnerMechanism(cli);
return;

void PromptWelcome(ConsoleInterface consoleInterface)
{
    consoleInterface.Print("Angry Bird CLI testing");
    consoleInterface.Print("Select Action");
}
/*
void GetSelection(ConsoleInterface consoleInterface, Pick pick1, Aim aim1, Shoot shoot1)
{
    var myUserInput = consoleInterface.UserInput;

    GameAction selectedGameAction; 
    GameAction GetCurrentInput(string input) => input switch
    {
        "pick" => selectedGameAction = pick1,
        "aim" => selectedGameAction = aim1,
        "shoot" => selectedGameAction = shoot1,
        _ => throw new ArgumentOutOfRangeException("not valid"),
    };

    selectedGameAction = GetCurrentInput(myUserInput);
    selectedGameAction.PrintSelectedGameAction(selectedGameAction.Name);
    selectedGameAction.GameActionDoes();
}
*/
/*
 *Mumbelly Jumbelly
 * 
void SpawnerProjectileMechanism(ConsoleInterface cli1)
{
    SpawnProjectiles(3);
    cli1.Print(projectileUnits.Count + " Projectiles");

    static T Spawn<T>() where T : new()
    {
        return new T();
    }

    void SpawnProjectiles(int num)
    {
        for (var i = 0; i < num; i++)
        {
            projectileUnits.Add(Spawn<Bird>()); 
        }
    }
}
void SpawnerTargetsMechanism(ConsoleInterface cli1)
{
    SpawnTargets(2);
    cli1.Print(targetUnits.Count + " Walls");

    static T Spawn<T>() where T : new()
    {
        return new T();
    }

    void SpawnTargets(int num)
    {
        for (var i = 0; i < num; i++)
        {
            targetUnits.Add(Spawn<Wall>()); 
        }
    }
}
void SpawnerPrisonnersMechanism(ConsoleInterface cli1)
{
    SpawnPrsionners(1);
    cli1.Print(prisonnersUnits.Count + " Prisonner");

    static T Spawn<T>() where T : new()
    {
        return new T();
    }

    void SpawnPrsionners(int num)
    {
        for (var i = 0; i < num; i++)
        {
            prisonnersUnits.Add(Spawn<Prisonner>()); 
        }
    }
}
*/
