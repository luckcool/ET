namespace ET.Client
{
    [Event(SceneType.LockStep)]
    public class LoginFinish_RemoveLockStepLoginUI : AEvent<Scene, LoginFinish>
    {
        protected override async ETTask Run(Scene scene, LoginFinish a)
        {
            scene.Root().GetComponent<FUIComponent>().ClosePanel(PanelId.LockStepLogin);
            await ETTask.CompletedTask;
        }
    }
}