using View;
namespace angrybird_logic.GameBehaviour;

public class KeyboardController : IController
{
    private ConsoleView Scene { get; set; }

    private string? Text { get; set; }
    /*
    public void SetScene(ConsoleView scene)
    {
        Scene = scene;
    }
    */

    public string? TextInput()
    {
        string? txt = Text;
        return txt;
    }
    public void PlayerInput()
    {
        Text = Scene.UserInput;
    }

    public void DisplayName()
    {
        Scene.Display("KeyboardController");
    }
}