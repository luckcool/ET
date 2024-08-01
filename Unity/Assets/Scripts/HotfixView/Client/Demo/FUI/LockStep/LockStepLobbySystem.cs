using System.IO;

namespace ET.Client
{
	[EntitySystemOf(typeof(LockStepLobby))]
	public static partial class LockStepLobbySystem
	{
		[EntitySystem]
		public static void Awake(this LockStepLobby self)
		{
		}

		public static void RegisterUIEvent(this LockStepLobby self)
		{
			self.FUILockStepLobby.btn_match.onClick.Add(self.OnEnterMap);
		}

		public static void OnShow(this LockStepLobby self, Entity contextData = null)
		{
		}

		public static void OnHide(this LockStepLobby self)
		{
		}

		public static void BeforeUnload(this LockStepLobby self)
		{
			self.FUILockStepLobby.btn_match.onClick.Remove(self.OnEnterMap);
		}

		public static void OnTranslate(this LockStepLobby self)
		{
		}

		private static void OnEnterMap(this LockStepLobby self)
		{
			self.EnterMap().Coroutine();
		}

		private static async ETTask EnterMap(this LockStepLobby self)
		{
			await EnterMapHelper.Match(self.Fiber());
		}
		
		private static void Replay(this LockStepLobby self)
		{
			byte[] bytes = File.ReadAllBytes(self.FUILockStepLobby.input_replaypath.text);
            
			Replay replay = MemoryPackHelper.Deserialize(typeof (Replay), bytes, 0, bytes.Length) as Replay;
			Log.Debug($"start replay: {replay.Snapshots.Count} {replay.FrameInputs.Count} {replay.UnitInfos.Count}");
			LSSceneChangeHelper.SceneChangeToReplay(self.Root(), replay).Coroutine();
		}
	}
}