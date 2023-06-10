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
        private int baseScore = 10;                 // 升级的基础分数
        private int upScore = 5;                    // 升级的每级递增分数
        private int curLevelScore = 0;              // 升级到当前等级需要的分数
        private int nextLevelScore = 0;             // 从当前等级升级到下一等级需要的分数
        public int score { get; private set; }      // 分数
        public int line { get; private set; }       // 消除行数
        public int level { get; private set; }      // 等级
        public int interval { get; private set; }   // timer 的 Interval
        public float goalRatio { get; private set; }// 从当前等级升级到下一等级已经获得分数的比例
        public LevelControl()
        {
        }
        /// <summary>
        /// 初始化数据，包括分数、行数、等级、比例、间隔
        /// </summary>
        /// <param name="difficultLevel"></param>
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
        /// <param name="clearLineNum">消除的行数</param>
        public void Update(int clearLineNum)
        {
            // 消除 1 行得 1 分
            if (clearLineNum == 1)
            {
                score += 1;
            }
            // 消除 2 行得 3 分
            else if (clearLineNum == 2)
            {
                score += 3;
            }
            // 消除 3 行得 5 分
            else if (clearLineNum == 3)
            {
                score += 5;
            }
            // 消除 4 行得 8 分
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
