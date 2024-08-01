namespace ET.Client
{
	[EntitySystemOf(typeof(DemoLogin))]
	public static partial class DemoLoginSystem
	{
		[EntitySystem]
		public static void Awake(this DemoLogin self)
		{
		}

		public static void RegisterUIEvent(this DemoLogin self)
		{
			self.FUIDemoLogin.btn_login.onClick.Add(self.OnLogin);
		}

		public static void OnShow(this DemoLogin self, Entity contextData = null)
		{
		}

		public static void OnHide(this DemoLogin self)
		{
		}

		public static void BeforeUnload(this DemoLogin self)
		{
			self.FUIDemoLogin.btn_login.onClick.Remove(self.OnLogin);
		}

		public static void OnTranslate(this DemoLogin self)
		{
		}

		private static void OnLogin(this DemoLogin self)
		{
			LoginHelper.Login(self.Root(),
				self.FUIDemoLogin.input_account.text,
				self.FUIDemoLogin.input_password.text).Coroutine();
		}
	}
}