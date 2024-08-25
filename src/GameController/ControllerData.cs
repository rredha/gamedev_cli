namespace gamedev.GameController;

public static class ControllerData
{
    public static List<string> Names =
        new()
        {
            "Wheel",
            "Double Pedals",
            "Lever Arm",
            "Mouse",
            "Keyboard",
        };

    public static List<string> Descriptions =
        new()
        {
            "A Wheel that could be used single or both handed.",
            "Control the game by synchronizing the motion of the two pedals.",
            "Simple Lever arm that goes in one direction.",
            "Traditional Computer mouse",
            "Traditional Keyboard.",
        };

    public static List<DegreeOfFreedom> Dof =
        new()
        {
            DegreeOfFreedom.One,
            DegreeOfFreedom.Two,
            DegreeOfFreedom.One,
            DegreeOfFreedom.Two,
            DegreeOfFreedom.One,
        };

    private static int _controllerCounts;
    public static int ControllerCount => NumberOfControllers(Names);

    private static int NumberOfControllers(List<string> controllerNames)
    {
        return controllerNames.Count;
    }
}