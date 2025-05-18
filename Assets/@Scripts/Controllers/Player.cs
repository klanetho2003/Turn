using UnityEngine;
using static Define;

public class Player : Creature
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        ObjectType = EObjectType.Player;

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
