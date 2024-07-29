using ET.Client.Test;

namespace ET.Client
{
	[ComponentOf(typeof(FUIEntity))]
	public class Main: Entity, IAwake
	{
		private FUI_Main _fuiMain;

		public FUI_Main FUIMain
		{
			get => _fuiMain ??= (FUI_Main)this.GetParent<FUIEntity>().GComponent;
		}
	}
}
