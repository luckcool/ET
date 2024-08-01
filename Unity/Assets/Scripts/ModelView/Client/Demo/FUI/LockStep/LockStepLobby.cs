using ET.Client.LockStep;

namespace ET.Client
{
	[ComponentOf(typeof(FUIEntity))]
	public class LockStepLobby: Entity, IAwake
	{
		private FUI_LockStepLobby _fuiLockStepLobby;

		public FUI_LockStepLobby FUILockStepLobby
		{
			get => _fuiLockStepLobby ??= (FUI_LockStepLobby)this.GetParent<FUIEntity>().GComponent;
		}
	}
}
