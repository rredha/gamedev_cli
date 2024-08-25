namespace gamedev.GameController;

public class ControllerLibrary
{
    public List<ControllerInfo> ControllerInfoList { get; private set; }

    public ControllerLibrary()
    {
        var controllersInfoList = new List<ControllerInfo>();
        for (var i = 0; i < ControllerData.ControllerCount; i++)
        {
            var controllerInfo = new ControllerInfo(
                                 ControllerData.Names[i],
                                 ControllerData.Descriptions[i],
                                     ControllerData.Dof[i]
            );
            controllersInfoList.Add(controllerInfo);
        }

        ControllerInfoList = controllersInfoList;
    }


    public string FormatControllerInfo(ControllerInfo info)
    {
        return info.Name + " : " + info.Description;
    }

}