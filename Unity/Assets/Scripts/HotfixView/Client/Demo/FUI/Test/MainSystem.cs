namespace ET.Client
{
	[EntitySystemOf(typeof(Main))]
	public static partial class MainSystem
	{
		[EntitySystem]
		public static void Awake(this Main self)
		{
		}

		public static void RegisterUIEvent(this Main self)
		{
		}

		public static void OnShow(this Main self, Entity contextData = null)
		{
		}

		public static void OnHide(this Main self)
		{
		}

		public static void BeforeUnload(this Main self)
		{
		}

		public static void OnTranslate(this Main self)
		{
		}
	}
}