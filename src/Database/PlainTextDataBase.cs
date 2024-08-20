using gamedev.Users.Lib;

namespace gamedev.Database;

public class PlainTextDataBase : IDatabase
{
   private const string Directory = @"/home/redha/share/games/gamedev/data/";
   private const string Filename = "test.txt";
   private readonly string _path = string.Concat(Directory, Filename);
   private bool _isDatabaseFound = false;

   public string[]? DatabaseContent { get; private set; }

   private void CheckForExistingDatabase()
   {
       _isDatabaseFound = File.Exists(_path);
   }

   private void CreateDatabaseDirectory()
   {
       CheckForExistingDatabase();
       if (!_isDatabaseFound)
       {
           System.IO.Directory.CreateDirectory(Directory);
       }
   }
   
   public bool IsAccessible { get; set; }
   
   

   public void Populate()
   {
       CreateDatabaseDirectory();
   }
   
   public void Send(Session session)
   {
       CheckForExistingDatabase();
       if(!_isDatabaseFound) return;
       File.WriteAllText(_path, session.User?.Data.UserName);
   }
   
   public void Retrieve()
   {
       CheckForExistingDatabase();
       if(!_isDatabaseFound) return;
       DatabaseContent = File.ReadAllLines(_path);
   }
}