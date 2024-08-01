using ET.Client.Demo;

namespace ET.Client
{
	[ComponentOf(typeof(FUIEntity))]
	public class DemoHelp: Entity, IAwake
	{
		private FUI_DemoHelp _fuiDemoHelp;

		public FUI_DemoHelp FUIDemoHelp
		{
			get => _fuiDemoHelp ??= (FUI_DemoHelp)this.GetParent<FUIEntity>().GComponent;
		}
	}
}
