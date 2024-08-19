using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [CreateAssetMenu(fileName = "NumericSetting", menuName = "ET/NumericSetting")]
    public class NumericSetting : ScriptableObject
    {
        public List<NumericInfo> numericInfos = new List<NumericInfo>();


    }

    [Serializable]
    public class NumericInfo
    {
        public string name;
        public int index = 0;
        public bool needBase;
        public bool needAdd;
        public bool needPct;
        public bool needFAdd;
        public bool needFPct;
    }
}