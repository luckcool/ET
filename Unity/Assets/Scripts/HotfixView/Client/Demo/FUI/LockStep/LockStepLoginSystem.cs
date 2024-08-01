namespace ET.Client
{
	[EntitySystemOf(typeof(LockStepLogin))]
	public static partial class LockStepLoginSystem
	{
		[EntitySystem]
		public static void Awake(this LockStepLogin self)
		{
		}

		public static void RegisterUIEvent(this LockStepLogin self)
		{
			self.FUILockStepLogin.btn_login.onClick.Add(self.OnLogin);
		}

		public static void OnShow(this LockStepLogin self, Entity contextData = null)
		{
		}

		public static void OnHide(this LockStepLogin self)
		{
		}

		public static void BeforeUnload(this LockStepLogin self)
		{
			self.FUILockStepLogin.btn_login.onClick.Remove(self.OnLogin);
		}

		public static void OnTranslate(this LockStepLogin self)
		{
		}

		private static void OnLogin(this LockStepLogin self)
		{
			LoginHelper.Login(self.Root(),
				self.FUILockStepLogin.input_account.text,
				self.FUILockStepLogin.input_password.text).Coroutine();
		}
	}
}