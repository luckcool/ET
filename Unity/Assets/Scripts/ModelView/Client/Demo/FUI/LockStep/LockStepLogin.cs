using ET.Client.LockStep;

namespace ET.Client
{
	[ComponentOf(typeof(FUIEntity))]
	public class LockStepLogin: Entity, IAwake
	{
		private FUI_LockStepLogin _fuiLockStepLogin;

		public FUI_LockStepLogin FUILockStepLogin
		{
			get => _fuiLockStepLogin ??= (FUI_LockStepLogin)this.GetParent<FUIEntity>().GComponent;
		}
	}
}
