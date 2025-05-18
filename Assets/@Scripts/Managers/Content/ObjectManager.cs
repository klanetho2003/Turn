using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static Define;

public class ObjectManager
{
    public Player Player { get; private set; }
    public HashSet<Enemy> Enemeys { get; } = new HashSet<Enemy>();

    public GameObject SpawnGameObject(Vector3 position, string prefabName)
    {
        GameObject go = Managers.Resource.Instantiate(prefabName, pooling: true);
        go.transform.position = position;
        return go;
    }

    public T Spawn<T>(Vector3 position, int templateID = 0) where T : BaseController
    {
        string prefabName = typeof(T).Name;

        GameObject go = Managers.Resource.Instantiate(prefabName, pooling: true);
        go.name = prefabName;
        go.transform.position = position;

        BaseController obj = go.GetComponent<BaseController>();

        if (obj.ObjectType == EObjectType.Player)
        {
            Player player = go.GetComponent<Player>();
            Player = player;
            player.SetInfo(templateID);
        }
        else if (obj.ObjectType == EObjectType.Enemey)
        {
            Enemy enemey = go.GetComponent<Enemy>();
            Enemeys.Add(enemey);
            enemey.SetInfo(templateID);
        }

        return obj as T;
    }

    public void Despawn<T>(T obj) where T : BaseController
    {
        GameObject objGameObject = obj.gameObject;
        if (objGameObject.IsValid() == false)
            return;

        EObjectType objectType = obj.ObjectType;

        if (obj.ObjectType == EObjectType.Player)
        {
            Player player = obj.GetComponent<Player>();
            Player = null;
        }
        else if (obj.ObjectType == EObjectType.Enemey)
        {
            Enemy enemey = obj.GetComponent<Enemy>();
            Enemeys.Remove(enemey);
        }

        // To Pool
        {
            string poolName = typeof(T).Name;
            obj.gameObject.name = poolName;
        }

        Managers.Resource.Destroy(obj.gameObject);

    }

    public void DespawnAllTemps()
    {
        var temps = Enemeys.ToList();

        foreach (var temp in temps)
            Managers.Object.Despawn(temp);
    }
}
