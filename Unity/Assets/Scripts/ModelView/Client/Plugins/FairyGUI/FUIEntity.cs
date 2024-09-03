﻿using FairyGUI;
using UnityEngine;

namespace ET.Client
{
    [ChildOf(typeof(FUIComponent))]
    public class FUIEntity : Entity, IAwake, IDestroy
    {
        private PanelId panelId = PanelId.Invalid;
        public GComponent GComponent { get; set; }
        public PanelCoreData PanelCoreData { get; set; }
        public EntityRef<Entity> ContextData { get; set; }
        public SystemLanguage Language { get; set; }
        public bool IsUsingStack { get; set; }
        public string PackageName { get; set; }
        public string ComponentName { get; set; }

        public bool IsPreLoad
        {
            get
            {
                return this.GComponent != null;
            }
        }

        public PanelId PanelId
        {
            get
            {
                if (this.panelId == PanelId.Invalid)
                {
                    Log.Error($"Panel Id is {PanelId.Invalid}");
                }

                return this.panelId;
            }

            set { this.panelId = value; }
        }
    }
}