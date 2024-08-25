namespace gamedev.GameCatalog;

public static class GameData
{
    public static List<string> Names =
        new()
        {
            "Snake",
            "Pong",
            "Brick Breaker",
            "Angry Bird",
            "Tetris",
            "Bubble Pop",
            "Fruit Ninja",
            "Asteroid",
            "Flappy Bird",
        };

    public static List<string> Descriptions =
        new()
        {
            "Eat as many Fruits as possible, without touching the walls.",
            "Beat the computer in a frenetic Ping Pong Game.",
            "Use the ball to break as many bricks as possible.",
            "Poor little birds are trapped, your mission is to free them",
            "Classic logic game, move the pieces to complete as many rows as possible.",
            "If a bubble appears...Just Pop It.",
            "Slash them Fruits.",
            "Avoid projectiles, the more you do, the higher your score.",
            "Control this cute little bird, you dont want to it to hit a wall right ?",
        };

    public static List<bool> IsLoop =
        new()
        {
            true,
            true,
            false,
            false,
            true,
            true,
            true,
            true,
            true,
        };

    public static List<DegreeOfFreedom> Dof =
        new()
        {
            DegreeOfFreedom.Two,
            DegreeOfFreedom.One,
            DegreeOfFreedom.One,
            DegreeOfFreedom.Two,
            DegreeOfFreedom.Two,
            DegreeOfFreedom.Three,
            DegreeOfFreedom.Two,
            DegreeOfFreedom.Two,
            DegreeOfFreedom.One,
        };

    private static int _gameCounts;
    public static int GameCounts => NumberOfGames(Names);

    private static int NumberOfGames(List<string> gameNames)
    {
        return gameNames.Count;
    }
}