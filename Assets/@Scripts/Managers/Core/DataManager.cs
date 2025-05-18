using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public interface ILoader<Key, Value>
{
    Dictionary<Key, Value> MakeDict();
}

public class DataManager
{
    // Example
    // public Dictionary<int, Data.ChildData> ChildDataDic { get; private set; } = new Dictionary<int, Data.ChildData>();

    public Dictionary<int, Data.PlayerData> PlayerDataDic { get; private set; } = new Dictionary<int, Data.PlayerData>();
    public Dictionary<int, Data.EnemyData> EnemyDataDic { get; private set; } = new Dictionary<int, Data.EnemyData>();

    public void Init()
    {
        // Example
        // ChildDataDic = LoadJson<Data.ChildDataLoader, int, Data.ChildData>("ChildData").MakeDict();

        PlayerDataDic = LoadJson<Data.PlayerDataLoader, int, Data.PlayerData>("PlayerData").MakeDict();
        EnemyDataDic = LoadJson<Data.EnemyDataLoader, int, Data.EnemyData>("EnemyData").MakeDict();
    }

    private Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>(path);
        return JsonConvert.DeserializeObject<Loader>(textAsset.text);
    }
}
