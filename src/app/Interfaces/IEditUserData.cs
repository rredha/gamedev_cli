namespace gamedev_cli.app.Interfaces;

public interface IEditUserData
{
    public UserData
    GetUserData(User<UserType.UserEnum> user);
    
    public void
    SetUserData(User<UserType.UserEnum> user,
                UserData data);
    
    public void
    UpdateUserData(User<UserType.UserEnum> user,
                   UserData data);
}