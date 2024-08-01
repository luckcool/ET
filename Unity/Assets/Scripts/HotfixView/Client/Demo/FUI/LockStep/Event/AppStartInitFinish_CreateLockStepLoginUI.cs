namespace ET.Client
{
    [Event(SceneType.LockStep)]
    public class AppStartInitFinish_CreateLockStepLoginUI : AEvent<Scene, AppStartInitFinish>
    {
        protected override async ETTask Run(Scene scene, AppStartInitFinish a)
        {
            await scene.Root().GetComponent<FUIComponent>().ShowPanelAsync(PanelId.LockStepLogin);
        }
    }
}