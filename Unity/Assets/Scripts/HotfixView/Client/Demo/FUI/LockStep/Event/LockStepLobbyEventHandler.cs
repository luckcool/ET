using System;
using ET.Client.LockStep;
using UnityEngine;

namespace ET.Client
{
	[FriendOf(typeof(PanelCoreData))]
	[FriendOf(typeof(FUIEntity))]
	[FUIEvent(PanelId.LockStepLobby, "LockStep", "LockStepLobby")]
	public class LockStepLobbyEventHandler: IFUIEventHandler
	{
		public void OnCreatePanel(FUIEntity fuiEntity)
		{
			fuiEntity.GComponent = FUI_LockStepLobby.CreateInstance();
		}
		public void OnInitPanelCoreData(FUIEntity fuiEntity)
		{
			fuiEntity.PanelCoreData.PanelType = UIPanelType.Panel;
		}

		public void OnInitComponent(FUIEntity fuiEntity)
		{
			LockStepLobby panel = fuiEntity.AddComponent<LockStepLobby>();
		}

		public void OnRegisterUIEvent(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLobby>().RegisterUIEvent();
		}

		public void OnShow(FUIEntity fuiEntity, Entity contextData = null)
		{
			fuiEntity.GetComponent<LockStepLobby>().OnShow(contextData);
		}

		public void OnHide(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLobby>().OnHide();
		}

		public void BeforeUnload(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLobby>().BeforeUnload();
		}

		public void OnTranslate(FUIEntity fuiEntity)
		{
			fuiEntity.GetComponent<LockStepLobby>().OnTranslate();
		}
	}
}