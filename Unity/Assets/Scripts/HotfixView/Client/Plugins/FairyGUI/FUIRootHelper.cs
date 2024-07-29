using System;
using FairyGUI;

namespace ET.Client
{
    public static class FUIRootHelper
    {
        public static GComponent GetTargetRoot(Scene scene,UIPanelType type)
        {
            GlobalComponent globalComponent = scene.GetComponent<GlobalComponent>();
            switch (type)
            {
                case UIPanelType.Bottom:
                    return globalComponent.BottomGRoot;
                case UIPanelType.Scene:
                    return globalComponent.SceneGRoot;
                case UIPanelType.Panel:
                    return globalComponent.PanelGRoot;
                case UIPanelType.Fix:
                    return globalComponent.FixGRoot;
                case UIPanelType.Popup:
                    return globalComponent.PopupGRoot;
                case UIPanelType.Tips:
                    return globalComponent.TipsGRoot;
                case UIPanelType.Top:
                    return globalComponent.TopGRoot;
            }
            
            Log.Error($"UIRoot type is error: {type.ToString()}");
            return null;
        }
    }
}