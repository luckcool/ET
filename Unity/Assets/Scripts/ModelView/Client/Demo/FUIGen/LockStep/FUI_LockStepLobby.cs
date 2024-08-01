/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET.Client.LockStep
{
	[EnableClass]
	public partial class FUI_LockStepLobby: GComponent
	{
		public GButton btn_match;
		public GButton btn_replay;
		public GTextInput input_replaypath;
		public const string URL = "ui://vn1qcc72b7fs2";

		public static FUI_LockStepLobby CreateInstance()
		{
			return (FUI_LockStepLobby)UIPackage.CreateObject("LockStep", "Lobby");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			btn_match = (GButton)GetChildAt(1);
			btn_replay = (GButton)GetChildAt(3);
			input_replaypath = (GTextInput)GetChildAt(4);
		}
	}
}
