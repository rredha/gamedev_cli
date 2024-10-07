namespace gamedev.User;

public static class UserManager
{
    public static Common? CurrentUser { get; private set; }

    public static Common CreateUser(string userType)
    {
        switch (userType)
        {
           case "UPatient" :
               Console.WriteLine("Hello i'm a patient");
               CurrentUser = new UPatient();
               return CurrentUser;
           case "UPhysicist" :
               Console.WriteLine("Hello i'm a physicist");
               CurrentUser = new UPhysicist();
               return CurrentUser;
           case "UDev" :
               Console.WriteLine("Hello i'm a dev");
               CurrentUser = new UDev();
               return CurrentUser;
           default:
               Console.WriteLine("By default, i'm a dev");
               CurrentUser = new UDev();
               return CurrentUser;
        } 
    }
}