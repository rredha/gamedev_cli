using gamedev;
using gamedev.Database;
using gamedev.lib.Mock;
using gamedev.Users.Lib;

{
#region Scene Setup
Scene scene = new Scene();
scene.DisplayText("Welcome to The Rehabilitation Platform",
                  ConsoleColor.DarkBlue);
#endregion

/*
 * 1- Create a session -> Done
 * 2- User as unset first -> Done
 * 3- Fill the information -> Done
 * 4- Store in PlainTextDataBase
 * 5- Display.
 */


#region Session Creation

Session session = new Session(1,
                      new PlainTextDataBase(),
                             new User(UserType.Unset));
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
session.Database.Send(session.User);
#endregion
}