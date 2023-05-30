using System;
using System.Collections.Generic;

namespace Tetris
{
    public enum Direction
    {
        Left,
        Up,
        Right,
        Down
    }

    public enum PenetrateState
    {
        NotStart,
        OnGoing,
        Penetrated
    }
}
