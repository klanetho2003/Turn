using UnityEngine;
using static Define;

public class Enemy : Creature
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        ObjectType = EObjectType.Enemey;

        return true;
    }

    public override void SetInfo(int templateId)
    {
        base.SetInfo(templateId);
    }

    public override void UpdateController()
    {
        base.UpdateController();
    }
}
