using System;
using System.Collections.Generic;

namespace ET
{
    public partial class TextConfigCategory
    {
        private Dictionary<string, TextConfig> sDict = new();

        public TextConfig Get(string sid)
        {
            this.sDict.TryGetValue(sid, out TextConfig item);

            if (item == null && (sid.StartsWith("UI_") || sid.StartsWith("ui_")))
            {
                Log.Error($"配置找不到，配置表名: {nameof (TextConfig)}，配置sid: {sid}");
            }

            return item;
        }
        
        public override void EndInit()
        {
            foreach (TextConfig textConfig in this.GetAll().Values)
            {
                this.sDict.Add(textConfig.Sid, textConfig);
            }
        }
    }
}