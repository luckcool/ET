using System;
using ET.Client.Demo;
using UnityEngine;

namespace ET.Client
{
	[FriendOf(typeof(PanelCoreData))]
	[FriendOf(typeof(FUIEntity))]
	[FUIEvent(PanelId.DemoLogin, "Demo", "DemoLogin")]
	public class DemoLoginEventHandler: IFUIEventHandler
	{
		public void OnCreatePanel(FUIEntity fuiEntity)
		{
			fuiEntity.GComponent = FUI_DemoLogin.CreateInstance();
		}
		public void OnInitPanelCoreData(FUIEntity fuiEntity)
		{
			fuiEntity.PanelCoreData.PanelType = UIPanelType.Panel;
		}

		public void OnInitComponent(FUIEntity fuiEntity)
		{
			DemoLogin panel = fuiEntity.AddComponent<DemoLogin>();
		}

		public void OnRegisterUIEvent(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoLogin>().RegisterUIEvent();
		}

		public void OnShow(FUIEntity fuiEntity, Entity contextData = null)
		{
			fuiEntity.GetComponent<DemoLogin>().OnShow(contextData);
		}

		public void OnHide(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoLogin>().OnHide();
		}

		public void BeforeUnload(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoLogin>().BeforeUnload();
		}

		public void OnTranslate(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<DemoLogin>().OnTranslate();
		}
	}
}