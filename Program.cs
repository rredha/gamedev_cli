using gamedev;
using gamedev.ApplicationState;
using gamedev.Database;
using gamedev.GameCatalog;
using gamedev.GameController;
using gamedev.lib.Mock;
using gamedev.Users.Lib;

{
#region Scene Setup
Scene scene = new Scene();
scene.DisplayText("Welcome to The Rehabilitation Platform",
                  ConsoleColor.DarkBlue);
#endregion

#region Session Creation
Session session = new Session(1,
                      new MockDatabase(),
                             new User(UserType.Patient));
#endregion

#region Application State Machine

var appStateContext = new AppStateContext(scene, session);
var appStateMachine = new AppStateMachine(appStateContext);

//appStateMachine.Start();
//appStateMachine.Update();
#endregion

#region User Data Entry and Database
/*
scene.DisplayText("Please enter your First Name", ConsoleColor.Blue);
if (session.User != null) session.User.Data = session.User.Data with { FirstName = scene.GetUserInput() };

scene.DisplayText("Please enter your Last Name", ConsoleColor.Blue);
if (session.User != null) session.User.Data = session.User.Data with { LastName = scene.GetUserInput() };

scene.DisplayText("Please enter your age", ConsoleColor.Blue);
if (session.User != null) session.User.Data = session.User.Data with { Age = scene.GetUserInput() };

scene.DisplayText(scene.GetUserData(session.User), ConsoleColor.Green);
scene.DisplayText(scene.GetUserStatus(session.User), ConsoleColor.Green);

session.Database?.Send(session);

session.Database?.Retrieve();
*/
#endregion

#region Game Catalog and Controller Library
/* 
 * Create a Game Class, that should be able to communicate
 *  between the States (application state, and game state)
 *  record data, that it will defer to the appropriate class,
 *  responsible for managing data and logging data.
 */

//    GameLibrary lib = new GameLibrary();
//    scene.DisplayText(lib.FormatGameInfo(lib.GameInfoList[2]), ConsoleColor.Red);

//    ControllerLibrary lib = new ControllerLibrary();
//    scene.DisplayText(lib.FormatControllerInfo(lib.ControllerInfoList[1]),
//                      ConsoleColor.Red);
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