namespace gamedev.User.Lib;

public class User
{
    public PersonalData Data { get; set; }
    public UserType Type { get; set; }
    public bool IsLogged { get; set; }

    /*
    public User(UserType type)
    {
        Type = type;
    }
    public User(UserData data, UserType type)
    {
        Data = data;
        Type = type;
    }
    */

}