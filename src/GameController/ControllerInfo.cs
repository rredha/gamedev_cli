namespace gamedev.GameController;

public class ControllerInfo
{
    public ControllerInfo(string name,
                          string desc,
                          DegreeOfFreedom dof
                          )
    {
        Name = name;
        Description = desc;
        DoF = dof;
    }

    public string Name { get; set; }
    public string Description { get;  set; }
    public DegreeOfFreedom DoF { get; set; }

}