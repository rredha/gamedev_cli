namespace gamedev_cli.app;

public class NewUser : User<UserType.UserEnum>
{
    public NewUser(UserData data) : base(data)
    {
    }
}