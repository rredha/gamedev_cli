namespace gamedev_cli.app;

public abstract class User<TUserEnum> where TUserEnum : Enum
{
    public UserData Data { get; private set; }
    protected User(UserData data)
    {
        Data = data;
    }

}