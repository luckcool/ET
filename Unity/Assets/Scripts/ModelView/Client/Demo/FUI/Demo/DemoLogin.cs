using ET.Client.Demo;

namespace ET.Client
{
	[ComponentOf(typeof(FUIEntity))]
	public class DemoLogin: Entity, IAwake
	{
		private FUI_DemoLogin _fuiDemoLogin;

		public FUI_DemoLogin FUIDemoLogin
		{
			get => _fuiDemoLogin ??= (FUI_DemoLogin)this.GetParent<FUIEntity>().GComponent;
		}
	}
}
