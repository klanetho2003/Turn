using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Define;

public class GameScene : BaseScene
{
    [SerializeField] // For Debug
    private int _currentStage = 0;
    public int CurrentStage { get { return _currentStage; } }

    EStageState _stageState = EStageState.None;
    public EStageState StageState 
    {
        get { return _stageState; }
        set
        {
            if (_stageState == value) return;

            _stageState = value;
        }
    }

    private void SwitchStageCoroutine()
    {
        IEnumerator coroutine = GetStageCoroutineForState(StageState);

        if (coroutine == null)
            return;
    }

    private IEnumerator GetStageCoroutineForState(EStageState state)
    {
        switch (state)
        {
            case EStageState.Start:
                return CoStartState();
            case EStageState.Battle:
                return CoBattleState();
            case EStageState.Move:
                return CoMoveState();
            case EStageState.Over:
                return CoOverState();
            case EStageState.Clear:
                return CoClearState();

            default:
                return null;
        }
    }

    private IEnumerator CoStartState()
    {
        yield return null;
    }

    private IEnumerator CoBattleState()
    {
        yield return null;
    }

    private IEnumerator CoMoveState()
    {
        yield return null;
    }

    private IEnumerator CoOverState()
    {
        yield return null;
    }

    private IEnumerator CoClearState()
    {
        yield return null;
    }

    public override void Clear()
    {
        
    }
}
