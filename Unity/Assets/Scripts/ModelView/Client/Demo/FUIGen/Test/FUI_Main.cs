/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET.Client.Test
{
	[EnableClass]
	public partial class FUI_Main: GComponent
	{
		public GButton btn1;
		public const string URL = "ui://w1m7ibbgw7760";

		public static FUI_Main CreateInstance()
		{
			return (FUI_Main)UIPackage.CreateObject("Test", "Main");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			btn1 = (GButton)GetChildAt(0);
		}
	}
}
