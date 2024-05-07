using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Text;
using angrybird_logic.ConsoleInterface;
using angrybird_logic.GAction;
using angrybird_logic.Units;
using angrybird_logic.StateMachine;

var cli = new ConsoleInterface();

PromptWelcome(cli);
var state = StateMachine.State.LevelInit;
var lvl = 1;
cli.Print("Level : " + lvl.ToString());
var prisonnersUnits = new List<Prisonner>();
var targetUnits = new List<Target>();
var projectileUnits = new List<Projectile>();
SpawnerProjectileMechanism(cli);
SpawnerTargetsMechanism(cli);
SpawnerPrisonnersMechanism(cli);
PromptSelection();

state = StateMachine.State.Pick;
PlayerPicking();

void PlayerPicking()
{
   /*
    * List all the projectiles that are available.
    * Set one of them as selected
    * Change state
    */

   if (projectileUnits.Count != 0)
   {
       cli.Print(projectileUnits.Count + " Projectiles Left");
       // error here, for some reason...
       if (cli.UserInput != "sel") return;
       // lets say that its picked and removed it from the list
       projectileUnits.RemoveAt(projectileUnits.Count);
       state = StateMachine.State.Aim;
       PlayerAiming();
   }
   else
   {
       state = StateMachine.State.Lost;
       PlayerLost();
   }
}

void PlayerAiming()
{
    cli.Print("I'm Freaking Aiming at something...");
}

void PlayerLost()
{
    cli.Print("Shoot i lost again...");
}

void PromptSelection()
{
    List<GameAction> selectableItems = new List<GameAction>();
    var pick  = new Pick
    {
        _cli = cli
    };
    var aim   = new Aim
    {
        _cli = cli
    };
    var shoot = new Shoot
    {
        _cli = cli
    };

    pick.Name = "pick";
    aim.Name = "aim";
    shoot.Name = "shoot";

    selectableItems.Add(pick);
    selectableItems.Add(aim);
    selectableItems.Add(shoot);
    // Sets all the options to be selectable...
    // which is not always the case.
    /*
    foreach (var gameAction in selectableItems)
    {
        gameAction.IsSelectable = true;
        gameAction.PrintSelectableGameAction(gameAction.Name);
    }
    */
    selectableItems[0].IsSelectable = true;
    selectableItems[1].IsSelectable = false;
    selectableItems[2].IsSelectable = false;
    
    // print selectable game actions
    foreach (var gameAction in selectableItems)
    {
        if (gameAction.IsSelectable)
        {
            gameAction.PrintSelectableGameAction(gameAction.Name);
        }
    }
    GetSelection(cli, pick, aim, shoot);
}

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
