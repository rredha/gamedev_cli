using gamedev_cli.app.Interfaces;

namespace gamedev_cli.app;

public class Dev : User, IEditUserData
{
    public Dev(UserData data, UserType type) : base(data, type)
    {
    }

    public UserData GetUserData(User user)
    {
        throw new NotImplementedException();
    }

    public void SetUserData(User user, UserData data)
    {
        throw new NotImplementedException();
    }

    public void UpdateUserData(User user, UserData data)
    {
        throw new NotImplementedException();
    }
}