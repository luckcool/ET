using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace ET
{
    [CustomEditor(typeof(NumericSetting))]
    public class NumericEditor : Editor
    {
        private int max = 10000;
        private int begin = 1000;
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            NumericSetting numericSetting = (NumericSetting)target;

            if (GUILayout.Button("导出"))
            {
                int currentIndex = this.begin;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("/* 内容由NumericSetting生成，请到Unity中修改 */");
                sb.AppendLine("namespace ET");
                sb.AppendLine("{");
                sb.AppendLine("\tpublic static class NumericType");
                sb.AppendLine("\t{");
                sb.AppendLine("\t\tpublic const int Max = 10000;");
                foreach (NumericInfo info in numericSetting.numericInfos)
                {
                    if (info.index == 0 || currentIndex > info.index || info.index >= this.max)
                    {
                        info.index = currentIndex;
                    }

                    currentIndex++;
                    
                    sb.AppendLine();

                    sb.AppendLine($"\t\tpublic const int {info.name} = {info.index};");
                    if (info.needBase)
                    {
                        sb.AppendLine($"\t\tpublic const int {info.name}Base = {info.name} * 10 + 1;");
                    }

                    if (info.needAdd)
                    {
                        sb.AppendLine($"\t\tpublic const int {info.name}Add = {info.name} * 10 + 2;");
                    }

                    if (info.needPct)
                    {
                        sb.AppendLine($"\t\tpublic const int {info.name}Pct = {info.name} * 10 + 3;");
                    }

                    if (info.needFAdd)
                    {
                        sb.AppendLine($"\t\tpublic const int {info.name}FinalAdd = {info.name} * 10 + 4;");
                    }

                    if (info.needFPct)
                    {
                        sb.AppendLine($"\t\tpublic const int {info.name}FinalPct = {info.name} * 10 + 5;");
                    }
                }
                sb.AppendLine("\t}");
                sb.AppendLine("}");
                
                File.WriteAllText(Application.dataPath + "/Scripts/Model/Share/Module/Numeric/NumericType.cs", sb.ToString());
            }
        }
    }
}