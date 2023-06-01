using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class LevelControl
    {
        private int scoreNum = 0;
        private int lineNum = 0;            // 已经消除的行数
        private int levelNum = 1;
        private int baseLine = 10;
        private int upLine = 2;
        private int curLevelLine = 0;       // 当前等级消除的行数
        private int nextLevelLine = 0;      // 达到等级需要再消除的行数
        private float goalRatio = 0;
        public int Score { get => scoreNum; }
        public int Line { get => lineNum; }
        public int Level { get => levelNum; set => levelNum = value; }
        public int Interval { get => LevelIntervalTable[levelNum]; }
        public float GoalRatio { get => goalRatio; }
        private readonly Dictionary<int, int> LevelIntervalTable = new Dictionary<int, int>() {
            {1, 1000},
            {2, 900},
            {3, 800},
            {4, 700},
            {5, 600},
            {6, 500},
            {7, 400},
            {8, 300},
            {9, 200},
            {10, 150},
            {11, 100},
            {12, 90},
            {13, 80},
            {14, 70},
            {15, 60},
            {16, 50}
        };
        public LevelControl()
        {
        }
        public void Init()
        {
            scoreNum = 0;
            lineNum = 0;
            goalRatio = 0;
            nextLevelLine = baseLine + upLine * (levelNum - 1);
        }
        /// <summary>
        /// 更新分数、等级、下落速度
        /// </summary>
        /// <param name="clearLineNum"></param>
        public void Update(int clearLineNum)
        {
            if (clearLineNum == 1)
            {
                scoreNum += 1;
            }
            else if (clearLineNum == 2)
            {
                scoreNum += 3;
            }
            else if (clearLineNum == 3)
            {
                scoreNum += 5;
            }
            else
            {
                scoreNum += 8;
            }
            lineNum += clearLineNum;
            // 按照消除行数计算等级
            if (lineNum  >= curLevelLine + nextLevelLine)
            {
                levelNum++;
                curLevelLine += nextLevelLine;
                nextLevelLine = baseLine + upLine * (levelNum - 1);
            }
            goalRatio = (float)(lineNum - curLevelLine) / nextLevelLine;
        }
    }
}
