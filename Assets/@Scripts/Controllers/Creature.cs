using UnityEngine;
using static Define;

public class Creature : BaseController
{
    ECreatureState _creatureState = ECreatureState.None;
    public ECreatureState CreatureState
    {
        get { return _creatureState; }
        set
        {
            if (_creatureState == value) return;

            _creatureState = value;
        }
    }

    #region Init & SetInfo
    public override bool Init()
    {
        if (base.Init() == false)
            return false;


        return true;
    }

    public virtual void SetInfo(int templateId)
    {
        
    }
    #endregion

    public override void UpdateController()
    {
        
    }

    #region Battle



    #endregion
}
