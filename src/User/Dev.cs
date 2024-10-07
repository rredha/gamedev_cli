using gamedev.Interfaces;
using gamedev.User.Lib;

namespace gamedev.User;

public class Dev : Lib.User, IEditUserData
{
    public Dev(UserData data, UserType type) : base(data, type)
    {
    }

    public UserData GetUserData(Lib.User user)
    {
        throw new NotImplementedException();
    }

    public void SetUserData(Lib.User user, UserData data)
    {
        throw new NotImplementedException();
    }

    public void UpdateUserData(Lib.User user, UserData data)
    {
        throw new NotImplementedException();
    }
}