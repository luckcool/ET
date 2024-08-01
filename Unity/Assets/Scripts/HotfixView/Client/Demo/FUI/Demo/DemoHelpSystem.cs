namespace ET.Client
{
	[EntitySystemOf(typeof(DemoHelp))]
	public static partial class DemoHelpSystem
	{
		[EntitySystem]
		public static void Awake(this DemoHelp self)
		{
		}

		public static void RegisterUIEvent(this DemoHelp self)
		{
		}

		public static void OnShow(this DemoHelp self, Entity contextData = null)
		{
		}

		public static void OnHide(this DemoHelp self)
		{
		}

		public static void BeforeUnload(this DemoHelp self)
		{
		}

		public static void OnTranslate(this DemoHelp self)
		{
		}
	}
}