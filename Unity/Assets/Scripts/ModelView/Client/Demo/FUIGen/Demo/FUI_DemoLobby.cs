/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET.Client.Demo
{
	[EnableClass]
	public partial class FUI_DemoLobby: GComponent
	{
		public GButton btn_enter;
		public const string URL = "ui://vocjx4gsb7fs1";

		public static FUI_DemoLobby CreateInstance()
		{
			return (FUI_DemoLobby)UIPackage.CreateObject("Demo", "Lobby");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			btn_enter = (GButton)GetChildAt(0);
		}
	}
}
