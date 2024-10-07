namespace gamedev.User.Data;

public interface IData
{
    public Dictionary<string, string> Construct(string field, string data);
}