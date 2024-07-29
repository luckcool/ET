using System;
using UnityEngine;

namespace ET.Client
{
    public interface IFUIEventHandler
    {
        void OnCreatePanel(FUIEntity fuiEntity);
        void OnInitPanelCoreData(FUIEntity fuiEntity);
        void OnInitComponent(FUIEntity fuiEntity);
        void OnRegisterUIEvent(FUIEntity fuiEntity);
        void OnShow(FUIEntity fuiEntity, Entity contextData = null);
        void OnHide(FUIEntity fuiEntity);
        void BeforeUnload(FUIEntity fuiEntity);
        void OnTranslate(FUIEntity fuiEntity);
    }
}