using System;
using ET.Client.LockStep;
using UnityEngine;

namespace ET.Client
{
	[FriendOf(typeof(PanelCoreData))]
	[FriendOf(typeof(FUIEntity))]
	[FUIEvent(PanelId.LockStepLogin, "LockStep", "LockStepLogin")]
	public class LockStepLoginEventHandler: IFUIEventHandler
	{
		public void OnCreatePanel(FUIEntity fuiEntity)
		{
			fuiEntity.GComponent = FUI_LockStepLogin.CreateInstance();
		}
		public void OnInitPanelCoreData(FUIEntity fuiEntity)
		{
			fuiEntity.PanelCoreData.PanelType = UIPanelType.Panel;
		}

		public void OnInitComponent(FUIEntity fuiEntity)
		{
			LockStepLogin panel = fuiEntity.AddComponent<LockStepLogin>();
		}

		public void OnRegisterUIEvent(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLogin>().RegisterUIEvent();
		}

		public void OnShow(FUIEntity fuiEntity, Entity contextData = null)
		{
			fuiEntity.GetComponent<LockStepLogin>().OnShow(contextData);
		}

		public void OnHide(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLogin>().OnHide();
		}

		public void BeforeUnload(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLogin>().BeforeUnload();
		}

		public void OnTranslate(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLogin>().OnTranslate();
		}
	}
}