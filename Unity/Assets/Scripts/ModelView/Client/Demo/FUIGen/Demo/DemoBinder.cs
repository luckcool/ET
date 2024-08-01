/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;

namespace ET.Client
{
	[EnableClass]
	public class DemoBinder
	{
		public static void BindAll()
		{
			UIObjectFactory.SetPackageItemExtension(ET.Client.Demo.FUI_DemoHelp.URL, typeof(ET.Client.Demo.FUI_DemoHelp));
			UIObjectFactory.SetPackageItemExtension(ET.Client.Demo.FUI_DemoLobby.URL, typeof(ET.Client.Demo.FUI_DemoLobby));
			UIObjectFactory.SetPackageItemExtension(ET.Client.Demo.FUI_DemoLogin.URL, typeof(ET.Client.Demo.FUI_DemoLogin));
		}
	}
}
