namespace gamedev.User.Data.Type;

public class Personal : IData
{
    public Personal(string firstName, string lastName, string age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string Age { get; set; }

    public Dictionary<string, string> Construct(string field, string data)
    {
        var temp = new Dictionary<string, string>();
        temp.Add("Last Name", LastName);
        temp.Add("First Name", FirstName);
        temp.Add("Age", Age);
        
        return temp;
    }
}