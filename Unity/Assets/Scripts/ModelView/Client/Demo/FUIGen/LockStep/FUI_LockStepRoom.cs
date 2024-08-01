/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET.Client.LockStep
{
	[EnableClass]
	public partial class FUI_LockStepRoom: GComponent
	{
		public Controller c1;
		public GTextField progress;
		public GTextField predict;
		public GTextField framecount;
		public GTextInput jumptocount;
		public GButton btn_speed;
		public GButton btn_jumpto;
		public GTextInput savename;
		public GButton btn_save;
		public const string URL = "ui://vn1qcc72b7fs3";

		public static FUI_LockStepRoom CreateInstance()
		{
			return (FUI_LockStepRoom)UIPackage.CreateObject("LockStep", "Room");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			c1 = GetControllerAt(0);
			progress = (GTextField)GetChildAt(0);
			predict = (GTextField)GetChildAt(1);
			framecount = (GTextField)GetChildAt(2);
			jumptocount = (GTextInput)GetChildAt(4);
			btn_speed = (GButton)GetChildAt(5);
			btn_jumpto = (GButton)GetChildAt(6);
			savename = (GTextInput)GetChildAt(9);
			btn_save = (GButton)GetChildAt(10);
		}
	}
}
