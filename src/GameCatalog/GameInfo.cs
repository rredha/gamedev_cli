namespace gamedev.GameCatalog;

public class GameInfo
{
    public GameInfo(string name,
                    string desc,
                    bool isLoop,
                    DegreeOfFreedom dof
                    )
    {
        Name = name;
        Description = desc;
        IsLoop = isLoop;
        DoF = dof;
    }

    public string Name { get; set; }
    public string Description { get;  set; }
    public bool IsLoop { get;  set; }
    public DegreeOfFreedom DoF { get; set; }

}