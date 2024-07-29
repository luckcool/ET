using FairyGUI;
using UnityEngine;

namespace ET
{
    [FriendOf(typeof(GlobalComponent))]
    public static partial class GlobalComponentSystem
    {
        [EntitySystem]
        public static void Awake(this GlobalComponent self)
        {
            self.Global = GameObject.Find("/Global").transform;
            self.Unit = GameObject.Find("/Global/Unit").transform;
            self.GlobalConfig = Resources.Load<GlobalConfig>("GlobalConfig");
            
            self.GRoot = GRoot.inst;
            
            self.BottomGRoot = new GComponent();
            self.BottomGRoot.gameObjectName = "BottomGRoot";
            self.GRoot.AddChild(self.BottomGRoot);
            
            self.SceneGRoot = new GComponent();
            self.SceneGRoot.gameObjectName = "SceneGRoot";
            self.GRoot.AddChild(self.SceneGRoot);
            
            self.PanelGRoot = new GComponent();
            self.PanelGRoot.gameObjectName = "PanelGRoot";
            self.GRoot.AddChild(self.PanelGRoot);
            
            self.FixGRoot = new GComponent();
            self.FixGRoot.gameObjectName = "FixGRoot";
            self.GRoot.AddChild(self.FixGRoot);
            
            self.PopupGRoot = new GComponent();
            self.PopupGRoot.gameObjectName = "PopupGRoot";
            self.GRoot.AddChild(self.PopupGRoot);
            
            self.TipsGRoot = new GComponent();
            self.TipsGRoot.gameObjectName = "TipsGRoot";
            self.GRoot.AddChild(self.TipsGRoot);
            
            self.TopGRoot = new GComponent();
            self.TopGRoot.gameObjectName = "TopGRoot";
            self.GRoot.AddChild(self.TopGRoot);
        }
    }
    
    [ComponentOf(typeof(Scene))]
    public class GlobalComponent: Entity, IAwake
    {
        public Transform Global;
        public Transform Unit { get; set; }

        public GlobalConfig GlobalConfig { get; set; }
        
        public GComponent GRoot { get; set; }
        
        public GComponent BottomGRoot { get; set; }
        
        public GComponent SceneGRoot { get; set; }
        
        public GComponent PanelGRoot { get; set; }
        
        public GComponent FixGRoot { get; set; }
        
        public GComponent PopupGRoot { get; set; }
        
        public GComponent TipsGRoot { get; set; }
        
        public GComponent TopGRoot { get; set; }
    }
}