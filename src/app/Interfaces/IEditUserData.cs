namespace gamedev_cli.app.Interfaces;

public interface IEditUserData
{
    public UserData
    GetUserData(User user);
    
    public void
    SetUserData(User user,
                UserData data);
    
    public void
    UpdateUserData(User user,
                   UserData data);
}