using ET.Client.LockStep;

namespace ET.Client
{
	[ComponentOf(typeof(FUIEntity))]
	public class LockStepRoom: Entity, IAwake, IUpdate
	{
		private FUI_LockStepRoom _fuiLockStepRoom;

		public FUI_LockStepRoom FUILockStepRoom
		{
			get => _fuiLockStepRoom ??= (FUI_LockStepRoom)this.GetParent<FUIEntity>().GComponent;
		}
		
		public int frame { get; set; }
		public int predictFrame { get; set; }
		
		public Room room { get; set; }
	}
}
