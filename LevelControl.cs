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
        private int baseScore = 10;
        private int upScore = 5;
        private int curLevelScore = 0;
        private int nextLevelScore = 0;
        public int score { get; private set; }
        public int line { get; private set; }
        public int level { get; private set; }
        public int interval { get; private set; }
        public float goalRatio { get; private set; }
        public LevelControl()
        {
        }
        public void Init(int difficultLevel)
        {
            score = 0;
            line = 0;
            level = 1;
            goalRatio = 0;
            if (difficultLevel == 1)
            {
                interval = 1000;
            }
            else if (difficultLevel == 2)
            {
                interval = 500;
            }
            else
            {
                interval = 200;
            }
            curLevelScore = 0;
            nextLevelScore = baseScore + upScore * (level - 1);
        }
        /// <summary>
        /// 更新分数、等级、下落速度
        /// </summary>
        /// <param name="clearLineNum"></param>
        public void Update(int clearLineNum)
        {
            if (clearLineNum == 1)
            {
                score += 1;
            }
            else if (clearLineNum == 2)
            {
                score += 3;
            }
            else if (clearLineNum == 3)
            {
                score += 5;
            }
            else
            {
                score += 8;
            }
            line += clearLineNum;
            // 按照分数计算等级
            if (score >= curLevelScore + nextLevelScore)
            {
                level++;
                curLevelScore += nextLevelScore;
                nextLevelScore = baseScore + upScore * (level - 1);
                // 更新下落速度
                if (interval > 500)
                {
                    interval -= 100;
                }
                else if (interval > 200 && interval <= 500)
                {
                    interval -= 50;
                }
                else
                {
                    interval /= 2;
                }
            }
            goalRatio = (float)(score - curLevelScore) / nextLevelScore;
        }
    }
}
