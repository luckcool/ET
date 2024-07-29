using System.Collections.Generic;
using System.Linq;

namespace ET
{
    //[Serializable]
    public class UIComponentInfo
    {
        public string Id;
        public string Name;
        public string PackageName;
        public List<string> UsedPackage;
    }
    
    //[CreateAssetMenu(menuName = "FairyGUI/UIComponentInfoMap", fileName = "UIComponentInfoMap", order = 0)]
    public class UIComponentInfoMap //: ScriptableObject
    {
        public List<UIComponentInfo> Infos;

        public UIComponentInfo GetComponentInfoById(string id)
        {
            return this.Infos.FirstOrDefault(componentInfo => componentInfo.Id == id);
        }

        public UIComponentInfo GetComponentInfoByPackageName(string componentName)
        {
            return this.Infos.FirstOrDefault(componentInfo => componentInfo.Name == componentName);
        }
    }
}