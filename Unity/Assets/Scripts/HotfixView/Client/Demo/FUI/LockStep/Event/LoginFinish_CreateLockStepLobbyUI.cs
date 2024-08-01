namespace ET.Client
{
    [Event(SceneType.LockStep)]
    public class LoginFinish_CreateLockStepLobbyUI : AEvent<Scene, LoginFinish>
    {
        protected override async ETTask Run(Scene scene, LoginFinish a)
        {
            await scene.Root().GetComponent<FUIComponent>().ShowPanelAsync(PanelId.LockStepLobby);
        }
    }
}