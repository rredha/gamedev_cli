﻿using gamedev;
using gamedev.ApplicationState;
using gamedev.Database;using gamedev.GameCatalog;
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
                      new PlainTextDataBase(),
                             new User(UserType.Patient));
#endregion

#region User Data Entry and Database
/*
scene.DisplayText("Please enter your First Name", ConsoleColor.Blue);
if (session.User != null) session.User.Data = session.User.Data with { FirstName = scene.GetUserInput() };

scene.DisplayText("Please enter your Last Name", ConsoleColor.Blue);
if (session.User != null) session.User.Data = session.User.Data with { LastName = scene.GetUserInput() };

scene.DisplayText("Please enter your Username", ConsoleColor.Blue);
if (session.User != null) session.User.Data = session.User.Data with { UserName = scene.GetUserInput() };

scene.DisplayText("Please enter your age", ConsoleColor.Blue);
if (session.User != null) session.User.Data = session.User.Data with { Age = scene.GetUserInput() };

scene.DisplayText(scene.GetUserData(session.User), ConsoleColor.Green);
scene.DisplayText(scene.GetUserStatus(session.User), ConsoleColor.Green);

session.Database.Populate();
session.Database.Send(session);

*/
#endregion

#region Application State Machine
/*
Session session = new Session(1,
                              new PlainTextDataBase(),
                              new User(UserType.Unset)
                              );

var appStateContext = new AppStateContext(scene, session);
var appStateMachine = new AppStateMachine
{
    Context = appStateContext
};
appStateMachine.InitialiseState();
appStateMachine.SetInitialState();
appStateMachine.CurrentState.AppStateChanged += appStateMachine.OnAppStateChanged;
//appStateMachine.Start();
//appStateMachine.Update();
*/
#endregion

#region Game Catalog and Controllers
/* 
 * Display the Game Catalog
 *  This one is based on the available controller.
 *  And also on the degree of freedom of the games.
 *
 * Display the current GameController
 *  And have a default behavior if no controller are detected.
 *  The default behavior is to set the controller to either
 *  keyboard, or mouse.
 *
 * Create a Game Class, that should be able to communicate
 *  between the States (application state, and game state)
 *  record data, that it will defer to the appropriate class,
 *  responsible for managing data and logging data.
 * 
 */
/*
GameCatalog Catalog = new GameCatalog();

scene.DisplayText(Catalog.FormatGameInfo(Catalog.SnakeInfo), ConsoleColor.Red);

*/
    GameLibrary lib = new GameLibrary();
    scene.DisplayText(lib.FormatGameInfo(lib.GameInfoList[2]), ConsoleColor.Red);

    #endregion
}