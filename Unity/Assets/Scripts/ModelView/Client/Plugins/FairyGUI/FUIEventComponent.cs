using System;
using System.Collections.Generic;

namespace ET.Client
{
    public struct PanelInfo
    {
        public PanelId PanelId;
        public string PackageName;
        public string ComponentName;
    }
    
    [Code]
    public class FUIEventComponent : Singleton<FUIEventComponent>, ISingletonAwake
    {
        public Dictionary<PanelId, IFUIEventHandler> UIEventHandlers { get; } = new();
        public Dictionary<PanelId, PanelInfo> PanelIdInfos { get; } = new();
        public Dictionary<string, PanelInfo> PanelTypeInfos { get; } = new();
        
        public bool isClicked { get; set; }
        public void Awake()
        {
            this.UIEventHandlers.Clear();
            this.PanelIdInfos.Clear();
            this.PanelTypeInfos.Clear();

            foreach (Type type in CodeTypes.Instance.GetTypes(typeof(FUIEventAttribute)))
            {
                object[] attrs = type.GetCustomAttributes(typeof(FUIEventAttribute), false);
                if (attrs.Length == 0)
                {
                    continue;
                }

                FUIEventAttribute attr = (FUIEventAttribute)attrs[0];
                this.UIEventHandlers.Add(attr.PanelId, Activator.CreateInstance(type) as IFUIEventHandler);
                this.PanelIdInfos.Add(attr.PanelId, attr.PanelInfo);
                this.PanelTypeInfos.Add(attr.PanelId.ToString(), attr.PanelInfo);
            }
        }

        public IFUIEventHandler GetUIEventHandler(PanelId panelId)
        {
            if (this.UIEventHandlers.TryGetValue(panelId, out IFUIEventHandler handler))
            {
                return handler;
            }
            Log.Error($"panelId:{panelId} is not have any uiEvent");
            return null;
        }

        public PanelInfo GetPanelInfo(PanelId panelId)
        {
            if (this.PanelIdInfos.TryGetValue(panelId, out PanelInfo panelInfo))
            {
                return panelInfo;
            }
            Log.Error($"panelId:{panelId} is not have any panelInfo");
            return default;
        }
    }
}