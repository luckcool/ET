using System;
using ET.Client.LockStep;
using UnityEngine;

namespace ET.Client
{
	[FriendOf(typeof(PanelCoreData))]
	[FriendOf(typeof(FUIEntity))]
	[FUIEvent(PanelId.LockStepRoom, "LockStep", "LockStepRoom")]
	public class LockStepRoomEventHandler: IFUIEventHandler
	{
		public void OnCreatePanel(FUIEntity fuiEntity)
		{
			fuiEntity.GComponent = FUI_LockStepRoom.CreateInstance();
		}
		public void OnInitPanelCoreData(FUIEntity fuiEntity)
		{
			fuiEntity.PanelCoreData.PanelType = UIPanelType.Scene;
		}

		public void OnInitComponent(FUIEntity fuiEntity)
		{
			LockStepRoom panel = fuiEntity.AddComponent<LockStepRoom>();
		}

		public void OnRegisterUIEvent(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepRoom>().RegisterUIEvent();
		}

		public void OnShow(FUIEntity fuiEntity, Entity contextData = null)
		{
			fuiEntity.GetComponent<LockStepRoom>().OnShow(contextData);
		}

		public void OnHide(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepRoom>().OnHide();
		}

		public void BeforeUnload(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepRoom>().BeforeUnload();
		}

		public void OnTranslate(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepRoom>().OnTranslate();
		}
	}
}