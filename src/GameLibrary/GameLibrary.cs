namespace gamedev.GameLibrary;

public class GameLibrary
{
    public List<GameInfo> GameInfoList { get; private set; }
    
    /*
    public GameLibrary()
    {
        var gamesInfoArray = new GameInfo[GameData.GameCounts];
        for (var i = 0; i < GameData.GameCounts; i++)
        {
            gamesInfoArray[i].Name = GameData.Names[i];
            gamesInfoArray[i].Description = GameData.Descriptions[i];
            gamesInfoArray[i].IsLoop = GameData.IsLoop[i];
            gamesInfoArray[i].DoF = GameData.Dof[i];
        }

        GameInfoArray = gamesInfoArray;
    }
    */


    public GameLibrary()
    {
        var gamesInfoList = new List<GameInfo>();
        for (var i = 0; i < GameData.GameCounts; i++)
        {
            var gameInfo = new GameInfo(
                GameData.Names[i],
                GameData.Descriptions[i],
                GameData.IsLoop[i],
                 GameData.Dof[i]
            );
            gamesInfoList.Add(gameInfo);
        }

        GameInfoList = gamesInfoList;
    }


    public string FormatGameInfo(GameInfo info)
    {
        return info.Name + " : " + info.Description;
    }

}