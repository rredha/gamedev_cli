using gamedev.Actions.UserRegistration;
using Cli.NET.Models;
using gamedev.lib.Mock;
using gamedev.User;
using gamedev.Survey;

{
#region Scene Setup
Scene scene = new Scene();
scene.DisplayText("Welcome to The Rehabilitation Software",
                  ConsoleColor.DarkBlue);
#endregion

#region State Machine



#endregion
#region User Registration
/*
var userRegistrationCommands = new CommandList
{
    { "Signin", new SigninCommand(scene) },
    { "Login", new LoginCommand(scene) }
};

scene.Options(userRegistrationCommands);
scene.Container.Register(userRegistrationCommands);
scene.WaitForUserCommand();
scene.DisplayText(UserManager.CurrentUser.PersonalData.ToString(), ConsoleColor.Black);
*/
#endregion

#region Integrated Survey System
/*
Processor processor = new Processor();
processor.Retrieve();
processor.Display();
*/

#endregion

#region Game Entry Point

/*
 * Game :
 * Create what constitute a game
 * - It should have an Entry
 * - Display some info
 * - When selected it should create a scene and launch the game logic.
 * - Should have a state.
 * - Should be able to communicate with the database.
 * - Should have a tracking system.
 */

#endregion
}
