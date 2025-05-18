using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    #region Manager
    public enum EScene
    {
        Unknown,
        TitleScene,
        GameScene,
    }

    public enum EKeyDownEvent
    {
        None = -1,

        D = 1,
        Space = 100,
    }

    public enum EKeyInputType
    {
        None = -1,

        Down,
        Up,
        Hold,
        DoubleTap
    }

    public enum Sound
    {
        Bgm,
        Effect,
    }

    public enum UIEvent
    {
        None,
        PointerEnter,
        PointerExit,
        Click,
        Pressed,
        PointerDown,
        PointerUp,
        BeginDrag,
        Drag,
        EndDrag,
    }
    #endregion

    public enum EObjectType
    {
        None,
        TempType,
    }

    public enum ELayer
    {
        Default = 0,
        TransparentFX = 1,
        IgnoreRaycast = 2,
        Dummy1 = 3,
        Water = 4,
        UI = 5,
    }
}
