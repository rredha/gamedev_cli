namespace gamedev.User;

public static class UserManager
{
    public static Common? CurrentUser { get; private set; }

    public static Common CreateUser(string userType)
    {
        switch (userType)
        {
           case "Patient" :
               Console.WriteLine("Hello i'm a patient");
               CurrentUser = new Patient();
               return CurrentUser;
           case "Physicist" :
               Console.WriteLine("Hello i'm a physicist");
               CurrentUser = new Physicist();
               return CurrentUser;
           case "Dev" :
               Console.WriteLine("Hello i'm a dev");
               CurrentUser = new Dev();
               return CurrentUser;
           default:
               Console.WriteLine("By default, i'm a dev");
               CurrentUser = new Dev();
               return CurrentUser;
        } 
    }
}