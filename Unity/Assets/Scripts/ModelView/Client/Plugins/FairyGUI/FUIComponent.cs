using System.Collections.Generic;

namespace ET.Client
{
    [ComponentOf(typeof(Scene))]
    public class FUIComponent : Entity, IAwake, IDestroy
    {
        public List<PanelId> VisiblePanelsQueue { get; } = new(10);
        public Dictionary<int, FUIEntity> AllPanelsDic { get; } = new(10);
        public List<PanelId> FUIEntitylistCached { get; } = new(10);
        public Dictionary<int, FUIEntity> VisiblePanelsDic { get; } = new(10);
        public Stack<PanelId> HidePanelsStack { get; } = new(10);
        public Dictionary<string, int> UIPackageRef { get; } = new();
        public Dictionary<string, FUIResourcesCache> UIPackageCaches { get; } = new();
        public UIComponentInfoMap UIComponentInfoMap { get; set; }
    }
}