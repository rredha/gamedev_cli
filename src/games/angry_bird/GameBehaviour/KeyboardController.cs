using View;
namespace angrybird_logic.GameBehaviour;

public class KeyboardController : IController
{
    public ConsoleView Scene { get; set; }

    public string? Text;

    public void PlayerInput()
    {
        Text = Scene.UserInput;
    }

    public string? TextInput()
    {
        PlayerInput();
        if (Text != null)
        {
            return Text;
        }

        return "nothing here";
    }
    public void DisplayName()
    {
        Scene.Display("KeyboardController");
    }
    
    
}