using System;
using UnityEngine;

namespace ET.Client
{
    [EntitySystemOf(typeof(LocalizeComponent))]
    public static partial class LocalizeComponentSystem
    {
        [EntitySystem]
        private static void Awake(this ET.Client.LocalizeComponent self)
        {
            self.CurrentLanguage = SystemLanguage.Chinese;
        }

        public static bool SwitchLanguage(this LocalizeComponent self, SystemLanguage language)
        {
            if (self.CurrentLanguage == language)
            {
                return false;
            }

            self.CurrentLanguage = language;

            EventSystem.Instance.Publish(self.Root(), new SwitchLanguage() { Language = language });
            return true;
        }

        public static string GetText(this LocalizeComponent self, string sid, string defaultValue = default)
        {
            defaultValue ??= sid;
            TextConfig textConfig = TextConfigCategory.Instance.Get(sid);
            if (textConfig == null)
            {
                return defaultValue;
            }

            string text = "";
            switch (self.CurrentLanguage)
            {
                case SystemLanguage.English:
                    text = textConfig.EN;
                    break;
                case SystemLanguage.Chinese:
                case SystemLanguage.ChineseSimplified:
                    text = textConfig.CN;
                    break;
                default:
                    text = defaultValue;
                    break;
            }

            if (string.IsNullOrEmpty(text))
            {
                text = defaultValue;
            }

            return text;
        }

        public static string GetText(this LocalizeComponent self, int id, string defaultValue = default)
        {
            defaultValue ??= id.ToString();
            TextConfig textConfig = TextConfigCategory.Instance.Get(id);
            string text = "";
            switch (self.CurrentLanguage)
            {
                case SystemLanguage.English:
                    text = textConfig.EN;
                    break;
                case SystemLanguage.Chinese:
                case SystemLanguage.ChineseSimplified:
                    text = textConfig.CN;
                    break;
                default:
                    text = defaultValue;
                    break;
            }

            if (string.IsNullOrEmpty(text))
            {
                text = defaultValue;
            }

            return text;
        }
    }
}