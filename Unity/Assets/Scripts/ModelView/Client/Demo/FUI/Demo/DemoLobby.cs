using ET.Client.Demo;

namespace ET.Client
{
	[ComponentOf(typeof(FUIEntity))]
	public class DemoLobby: Entity, IAwake
	{
		private FUI_DemoLobby _fuiDemoLobby;

		public FUI_DemoLobby FUIDemoLobby
		{
			get => _fuiDemoLobby ??= (FUI_DemoLobby)this.GetParent<FUIEntity>().GComponent;
		}
	}
}
