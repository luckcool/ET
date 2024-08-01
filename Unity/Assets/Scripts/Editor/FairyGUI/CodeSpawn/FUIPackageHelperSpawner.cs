using System.Collections.Generic;
using System.IO;
using System.Text;
using ET;

namespace FUIEditor
{
    public static class FUIPackageHelperSpawner
    {
        public static void GenerateMappingFile()
        {
            UIComponentInfoMap uiComponentInfoMap = new();
            uiComponentInfoMap.Infos = new List<UIComponentInfo>();
            foreach (PackageInfo packageInfo in FUICodeSpawner.PackageInfos.Values)
            {
                foreach (PackageComponentInfo packageComponentInfo in packageInfo.PackageComponentInfos.Values)
                {
                    if (packageComponentInfo.Exported)
                    {
                        UIComponentInfo ci = new UIComponentInfo();
                        ci.Id = packageComponentInfo.Id;
                        ci.Name = $"{packageInfo.Name}{packageComponentInfo.Name.Replace(".xml","")}";
                        ci.PackageName = packageInfo.Name;
                        ci.UsedPackage = new List<string>(packageComponentInfo.UsedPackages);
                        uiComponentInfoMap.Infos.Add(ci);
                    }
                }
            }
            string filePath = $"../Unity/Assets/Bundles/FUI/UIMap/UIComponentInfoMap.json";
            string dir = filePath.Substring(0, filePath.LastIndexOf('/'));
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.WriteAllText(filePath, MongoHelper.ToJson(uiComponentInfoMap), Encoding.UTF8);
            uiComponentInfoMap = null;
        }
    }
}