/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET.Client.LockStep
{
	[EnableClass]
	public partial class FUI_LockStepLogin: GComponent
	{
		public GButton btn_login;
		public GTextInput input_account;
		public GTextInput input_password;
		public const string URL = "ui://vn1qcc72b7fs0";

		public static FUI_LockStepLogin CreateInstance()
		{
			return (FUI_LockStepLogin)UIPackage.CreateObject("LockStep", "Login");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			btn_login = (GButton)GetChildAt(1);
			input_account = (GTextInput)GetChildAt(3);
			input_password = (GTextInput)GetChildAt(5);
		}
	}
}
