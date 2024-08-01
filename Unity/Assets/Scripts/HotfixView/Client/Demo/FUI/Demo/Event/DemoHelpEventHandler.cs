using System;
using ET.Client.Demo;
using UnityEngine;

namespace ET.Client
{
	[FriendOf(typeof(PanelCoreData))]
	[FriendOf(typeof(FUIEntity))]
	[FUIEvent(PanelId.DemoHelp, "Demo", "DemoHelp")]
	public class DemoHelpEventHandler: IFUIEventHandler
	{
		public void OnCreatePanel(FUIEntity fuiEntity)
		{
			fuiEntity.GComponent = FUI_DemoHelp.CreateInstance();
		}
		public void OnInitPanelCoreData(FUIEntity fuiEntity)
		{
			fuiEntity.PanelCoreData.PanelType = UIPanelType.Panel;
		}

		public void OnInitComponent(FUIEntity fuiEntity)
		{
			DemoHelp panel = fuiEntity.AddComponent<DemoHelp>();
		}

		public void OnRegisterUIEvent(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoHelp>().RegisterUIEvent();
		}

		public void OnShow(FUIEntity fuiEntity, Entity contextData = null)
		{
			fuiEntity.GetComponent<DemoHelp>().OnShow(contextData);
		}

		public void OnHide(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoHelp>().OnHide();
		}

		public void BeforeUnload(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoHelp>().BeforeUnload();
		}

		public void OnTranslate(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoHelp>().OnTranslate();
		}
	}
}