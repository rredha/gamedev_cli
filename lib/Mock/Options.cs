using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Interfaces;
namespace gamedev.lib.Mock;

public class Options
{
    public Scene _currentScene { get;  set; }

    private Dictionary<string, ICommand> options = new Dictionary<string, ICommand>();

    public void AddOptions(string optionName, ICommand command)
    {
       options.Add(optionName, command); 
    }
    
    public void CreateOptionList(Dictionary<string, ICommand> options)
    {
        foreach (var option in options)
        {
            _currentScene.Container.Register(option.Key, option.Value);
        }
    }
}