namespace View;

public class Logger
{
    public Logger(ConsoleView scene, bool showLogs)
    {
        _scene = scene;
        _showLogs = showLogs;
    }
    private bool _showLogs;
    private ConsoleView _scene;

    public void Log(string message)
    {
        if(_showLogs)
            _scene.Print("\t " + message);
    }
}