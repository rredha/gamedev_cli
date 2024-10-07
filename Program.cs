using gamedev.Actions.UserRegistration;
using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Models;
using gamedev.lib.Mock;
using gamedev.User;

{
#region Scene Setup
Scene scene = new Scene();
scene.DisplayText("Welcome to The Rehabilitation Software",
                  ConsoleColor.DarkBlue);
var userRegistrationCommands = new CommandList
{
    { "Signin", new SigninCommand(scene) },
    { "Login", new LoginCommand(scene) }
};

scene.Options(userRegistrationCommands);
scene.Container.Register(userRegistrationCommands);
scene.WaitForUserCommand(); 
scene.DisplayText(UserManager.CurrentUser.PersonalData.ToString(), ConsoleColor.Black);
#endregion

#region Game Entry

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