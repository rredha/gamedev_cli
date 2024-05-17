using angrybird_logic.Units;
namespace angrybird_logic.GAction;

public class LevelManager
{
    /*
     * Should be able to
     *      - Set the level.
     *      - Setup the current Level
     *          this is done by spawning the required elements on the scene.
     *      - Store the level at the end. so a getter for the current level.
     */

    private bool IsLoop { get; set; }
    private int _currentLevel = 0; 

    public LevelManager(bool isLoop)
    {
        IsLoop = isLoop;
    }

    public void Launch()
    {
        Level lvl = new Level(_currentLevel);  
        if (!IsLoop)
        {
            lvl.Initialise();
            _currentLevel++;
        }
    }

    private void NextLevel()
    {
        
    }
    
}