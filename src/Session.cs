using Cli.NET.Interfaces.Actions;
using gamedev.ApplicationState;
using gamedev.User;
using gamedev.Database;

namespace gamedev;

public class Session
{
   public  int Id { get; set; } = 0;
   public  IDatabase? Database { get; set; }
   public  AppState AppState { get; set; }
   
   public UserManager UserManager { get; set; }

}