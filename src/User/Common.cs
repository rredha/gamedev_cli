using gamedev.User.Data.Type;

namespace gamedev.User;

public abstract class Common
{
    public Personal PersonalData { get; set; }

    protected Common(Personal personalData)
    {
        PersonalData = personalData;
    }
    
    protected Common()
    {
    }
}