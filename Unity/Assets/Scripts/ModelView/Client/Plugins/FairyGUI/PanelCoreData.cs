using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ET.Client
{
    public enum UIPanelType
    {
        Bottom,
        Scene,
        Panel,
        Fix,
        Popup,
        Tips,
        Top
    }
    
    [ChildOf(typeof(FUIEntity))]
    public class PanelCoreData : Entity, IAwake
    {
        public UIPanelType PanelType { get; set; } = UIPanelType.Panel;
    }
}
