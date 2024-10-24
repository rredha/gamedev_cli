using Cli.NET.Interfaces.Actions;
using Cli.NET.Models;
using gamedev;
using gamedev.ApplicationState;
using gamedev.ApplicationState.Stages;
using gamedev.ApplicationState.Stages.UserRegistration;
using gamedev.Database;
using gamedev.lib.Mock;
using gamedev.User;
using gamedev.Survey;

{
#region Scene Setup
Scene scene = new Scene();
scene.DisplayText("Welcome to The Rehabilitation Software",
                  ConsoleColor.DarkBlue);
#endregion

#region Session Creation

Session session = new Session();
session.Id = 0;
session.Database = new MockDatabase();
session.AppState = new UserRegistrationState(scene, session);
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
