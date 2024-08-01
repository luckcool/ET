namespace ET.Client
{
    [Event(SceneType.Current)]
    public class SceneChangeFinishEvent_CreateHelpUI : AEvent<Scene, SceneChangeFinish>
    {
        protected override async ETTask Run(Scene scene, SceneChangeFinish a)
        {
            await scene.Root().GetComponent<FUIComponent>().ShowPanelAsync(PanelId.DemoHelp);
        }
    }
}