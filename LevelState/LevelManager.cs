using angrybird_logic.Units;
using Utils;
using View;

namespace angrybird_logic.GAction;

    /*
     * Should be able to
     *      - Set the level.
     *      - Setup the current Level
     *          this is done by spawning the required elements on the scene.
     *      - Store the level at the end. so a getter for the current level.
     */
public class LevelManager : StateMachine
{
    private bool IsLoop { get; set; }
    private int _currentLevel = 0; 
    private Logger _logger;
    private State _state { get; }

    public LevelManager(bool isLoop, Logger logger)
    {
        IsLoop = isLoop;
        _logger = logger;
    }

    public void GetLog()
    {
        _logger.Log("Current level " + _currentLevel.ToString());
    }
    
    /*
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
*/    
}