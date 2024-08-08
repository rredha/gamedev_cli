using gamedev_cli.app.Interfaces;

namespace gamedev_cli.app;

public class Dev : User<UserType.UserEnum>, IEditUserData
{
    public Dev(UserData data) : base(data)
    {
    }

    public UserData GetUserData(User<UserType.UserEnum> user)
    {
        throw new NotImplementedException();
    }

    public void SetUserData(User<UserType.UserEnum> user, UserData data)
    {
        throw new NotImplementedException();
    }

    public void UpdateUserData(User<UserType.UserEnum> user, UserData data)
    {
        throw new NotImplementedException();
    }
}