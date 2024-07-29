using FairyGUI;

namespace ET.Client
{
    [EntitySystemOf(typeof(FUIFullScreenComponent))]
    public static partial class FUIFullScreenComponentSystem
    {
        [EntitySystem]
        private static void Awake(this ET.Client.FUIFullScreenComponent self)
        {
            GRoot.inst.onSizeChanged.Add(self.OnSizeChange);
            self.OnSizeChange();
        }
        [EntitySystem]
        private static void Destroy(this ET.Client.FUIFullScreenComponent self)
        {
            GRoot.inst.onSizeChanged.Remove(self.OnSizeChange);
        }

        private static void OnSizeChange(this FUIFullScreenComponent self)
        {
            self.GetParent<FUIEntity>().GComponent.MakeFullScreen();
        }
    }
}