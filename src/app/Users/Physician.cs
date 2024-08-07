using gamedev_cli.app.Interfaces;

namespace gamedev_cli.app;

public class Physician : User<UserType.UserEnum>, IEditUserData
{
    public Physician(UserData data) : base(data)
    {
    }

    
    public UserData GetUserData(UserType.UserEnum userType, User<UserType.UserEnum> user)
    {
        if (userType == UserType.UserEnum.Patient)
        {
            return user.Data;
        }

        return null;
    }

    public void SetUserData(UserType.UserEnum userType, UserData data)
    {
        throw new NotImplementedException();
    }

    public void UpdateUserData(UserType.UserEnum userType, User<UserType.UserEnum> user, UserData data)
    {
        throw new NotImplementedException();
    }
}