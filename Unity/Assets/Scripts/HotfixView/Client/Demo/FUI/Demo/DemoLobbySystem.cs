namespace ET.Client
{
	[EntitySystemOf(typeof(DemoLobby))]
	public static partial class DemoLobbySystem
	{
		[EntitySystem]
		public static void Awake(this DemoLobby self)
		{
		}

		public static void RegisterUIEvent(this DemoLobby self)
		{
			self.FUIDemoLobby.btn_enter.onClick.Add(self.OnEnterMap);
		}

		public static void OnShow(this DemoLobby self, Entity contextData = null)
		{
		}

		public static void OnHide(this DemoLobby self)
		{
		}

		public static void BeforeUnload(this DemoLobby self)
		{
			self.FUIDemoLobby.btn_enter.onClick.Remove(self.OnEnterMap);
		}

		public static void OnTranslate(this DemoLobby self)
		{
		}

		private static void OnEnterMap(this DemoLobby self)
		{
			self.EnterMap().Coroutine();
		}

		private static async ETTask EnterMap(this DemoLobby self)
		{
			Scene root = self.Root();
			await EnterMapHelper.EnterMapAsync(root);
			self.Root().GetComponent<FUIComponent>().ClosePanel(PanelId.DemoLobby);
		}
	}
}