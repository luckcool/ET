using UnityEngine;

namespace ET.Client
{
    [EntitySystemOf(typeof(LockStepRoom))]
    public static partial class LockStepRoomSystem
    {
        [EntitySystem]
        public static void Awake(this LockStepRoom self)
        {
        }

        public static void RegisterUIEvent(this LockStepRoom self)
        {
            Room room = self.Room();
            self.FUILockStepRoom.c1.selectedIndex = room.IsReplay ? 0 : 1;
            if (room.IsReplay)
            {
                self.FUILockStepRoom.framecount.text = self.Room().Replay.FrameInputs.Count.ToString();
                self.FUILockStepRoom.btn_jumpto.onClick.Add(self.JumpReplay);
                self.FUILockStepRoom.btn_speed.onClick.Add(self.OnReplaySpeedClicked);
            }
            else
            {
                self.FUILockStepRoom.btn_save.onClick.Add(self.OnSaveReplay);
            }
        }

        public static void OnShow(this LockStepRoom self, Entity contextData = null)
        {
        }

        public static void OnHide(this LockStepRoom self)
        {
        }

        public static void BeforeUnload(this LockStepRoom self)
        {
            Room room = self.Room();
            if (room.IsReplay)
            {
                self.FUILockStepRoom.btn_jumpto.onClick.Remove(self.JumpReplay);
                self.FUILockStepRoom.btn_speed.onClick.Remove(self.OnReplaySpeedClicked);
            }
            else
            {
                self.FUILockStepRoom.btn_save.onClick.Remove(self.OnSaveReplay);
            }
        }

        public static void OnTranslate(this LockStepRoom self)
        {
        }
        
        [EntitySystem]
        private static void Update(this LockStepRoom self)
        {
            Room room = self.Room();
            if (self.frame != room.AuthorityFrame)
            {
                self.frame = room.AuthorityFrame;
                self.FUILockStepRoom.progress.text = room.AuthorityFrame.ToString();
            }
            
            if (!room.IsReplay)
            {
                if (self.predictFrame != room.PredictionFrame)
                {
                    self.predictFrame = room.PredictionFrame;
                    self.FUILockStepRoom.predict.text = room.PredictionFrame.ToString();
                }
            }
        }
        
        private static void OnSaveReplay(this LockStepRoom self)
        {
            string name = self.FUILockStepRoom.savename.text;

            LSClientHelper.SaveReplay(self.Room(), name);
        }

        private static void JumpReplay(this LockStepRoom self)
        {
            int toFrame = int.Parse(self.FUILockStepRoom.jumptocount.text);
            LSClientHelper.JumpReplay(self.Room(), toFrame);
        }

        private static void OnReplaySpeedClicked(this LockStepRoom self)
        {
            LSReplayUpdater lsReplayUpdater = self.Room().GetComponent<LSReplayUpdater>();
            lsReplayUpdater.ChangeReplaySpeed();
            self.FUILockStepRoom.btn_speed.title = $"X{lsReplayUpdater.ReplaySpeed}";
        }
    }
}