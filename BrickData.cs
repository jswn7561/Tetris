using System;
using System.Collections.Generic;

namespace Tetris
{
    internal struct BrickData
    {
        public bool rotatable;
        public bool penetrable;
        public int[][] layout;
        public string color;   //增加颜色
    }
}
