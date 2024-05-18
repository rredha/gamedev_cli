using angrybird_logic.Units;
using Utils;
using View;

namespace angrybird_logic.GAction;

public class LevelManager : StateMachine
{
    /*
     * Should be able to
     *      - Set the level.
     *      - Setup the current Level
     *          this is done by spawning the required elements on the scene.
     *      - Store the level at the end. so a getter for the current level.
     */

    public LevelManager(bool isLoop)
    {
        IsLoop = isLoop;
    }
    public ConsoleView? cli { get; set; }
    private bool IsLoop { get; set; }
    private int _currentLevel = 0; 


    public void Launch()
    {
        Level level = new Level(this);
        if (!IsLoop)
        {
            SetState(new Level(this));
            //level.Initialise();
            _currentLevel++;
        }
    }

    private void NextLevel()
    {
        
    }
    
}