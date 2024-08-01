/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET.Client.Demo
{
	[EnableClass]
	public partial class FUI_DemoLogin: GComponent
	{
		public GButton btn_login;
		public GTextInput input_account;
		public GTextInput input_password;
		public const string URL = "ui://vocjx4gsb7fs3";

		public static FUI_DemoLogin CreateInstance()
		{
			return (FUI_DemoLogin)UIPackage.CreateObject("Demo", "Login");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			btn_login = (GButton)GetChildAt(0);
			input_account = (GTextInput)GetChildAt(2);
			input_password = (GTextInput)GetChildAt(4);
		}
	}
}
