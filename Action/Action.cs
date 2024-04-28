namespace angrybird_logic.Action
{
    using angrybird_logic.ConsoleInterface;

public class Action
{
    ConsoleInterface _cli = new ConsoleInterface();
    
    public static string Name;
    private List<Action> _actions = new List<Action>();

    public void CreateAction(string actionName)
    {
        Action.Name = actionName;
    }

    public void CreateActionList(Action[] actionArray)
    {
        foreach (var action in actionArray)
        {
            _actions.Add(action);
        }
    }

    public void ListActions(List<string> actions)
    {
        foreach (var action in actions)
        {
            _cli.Print(action);
        }
    }
}
    
}
