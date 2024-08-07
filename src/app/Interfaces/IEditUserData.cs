namespace gamedev_cli.app.Interfaces;

public interface IEditUserData
{
    public UserData
    GetUserData(UserType.UserEnum userType,
                User<UserType.UserEnum> user);
    
    public void
    SetUserData(UserType.UserEnum userType,
                UserData data);
    
    public void
    UpdateUserData(UserType.UserEnum userType,
                   User<UserType.UserEnum> user,
                   UserData data);
}