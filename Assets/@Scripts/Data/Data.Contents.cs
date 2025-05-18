using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.Mathematics;
using UnityEngine;
using static Define;

namespace Data
{
    #region Example
    public class ParentData
    {
        public int TemplateId;
    }

    [Serializable]
    public class ChildData : ParentData
    {
        public int TempIntData;
        public string TempStringData;
        public List<ListData> TempListData = new List<ListData>();
    }

    [Serializable]
    public class ListData
    {
        public int Value_1;
        public int ObjectTemplateId;
    }

    [Serializable]
    public class ChildDataLoader : ILoader<int, ChildData>
    {
        public List<ChildData> Childs = new List<ChildData>();
        public Dictionary<int, ChildData> MakeDict()
        {
            Dictionary<int, ChildData> dict = new Dictionary<int, ChildData>();
            foreach (ChildData child in Childs)
                dict.Add(child.TemplateId, child);
            return dict;
        }
    }
    #endregion

    public class CreatureData
    {
        public int TemplateDataId;
        public string CreatureNameId;
        public int MaxHp;
    }

    #region Player Data
    [Serializable]
    public class PlayerData : CreatureData
    {
        
    }

    [Serializable]
    public class PlayerDataLoader : ILoader<int, PlayerData>
    {
        public List<PlayerData> PlayerDatas = new List<PlayerData>();
        public Dictionary<int, PlayerData> MakeDict()
        {
            Dictionary<int, PlayerData> dataDic = new Dictionary<int, PlayerData>();
            foreach (PlayerData data in PlayerDatas)
                dataDic.Add(data.TemplateDataId, data);
            return dataDic;
        }
    }
    #endregion

    [Serializable]
    public class EnemyData : CreatureData
    {

    }

    [Serializable]
    public class EnemyDataLoader : ILoader<int, EnemyData>
    {
        public List<EnemyData> EnemyDatas = new List<EnemyData>();
        public Dictionary<int, EnemyData> MakeDict()
        {
            Dictionary<int, EnemyData> dataDic = new Dictionary<int, EnemyData>();
            foreach (EnemyData data in EnemyDatas)
                dataDic.Add(data.TemplateDataId, data);
            return dataDic;
        }
    }
}
