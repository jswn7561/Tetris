using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    internal class Brick
    {
        public const int Size = 40;
        public const int Space = 2;
        public const int SizeWithSpace = Size + Space;
        public Point position { get; private set; }

        private BrickData data;
        private PenetrateState penetrateState;

        public Brick(BrickData data)
        {
            this.data = data;
            var minY = GetMinY();
            position = new Point(Game.Instance.mapSize.Width / SizeWithSpace / 2 * SizeWithSpace, -minY * SizeWithSpace);
        }

        private int GetMinY()
        {
            var min = int.MaxValue;
            foreach (var item in data.layout)
            {
                if (item[1] < min)
                {
                    min = item[1];
                }
            }

            return min;
        }

        public Rectangle GetBound()
        {
            var topLeft = new Point(int.MaxValue, int.MaxValue);
            var bottomRight = new Point(int.MinValue, int.MinValue);
            foreach (var item in data.layout)
            {
                if (item[0] < topLeft.X)
                {
                    topLeft.X = item[0];
                }

                if (item[0] > bottomRight.X)
                {
                    bottomRight.X = item[0];
                }

                if (item[1] < topLeft.Y)
                {
                    topLeft.Y = item[1];
                }

                if (item[1] > bottomRight.Y)
                {
                    bottomRight.Y = item[1];
                }
            }

            return new Rectangle(topLeft.X, topLeft.Y, bottomRight.X - topLeft.X + 1, bottomRight.Y - topLeft.Y + 1);
        }

        public void Paint(Graphics g)
        {
            Paint(g, position.X, position.Y, 1);
        }

        public void Paint(Graphics g, float posX, float posY, float scale)
        {
            var containerState = g.BeginContainer();

            g.TranslateTransform(posX, posY);
            g.ScaleTransform(scale, scale);

            //颜色格式转换
            Color myColor = ColorTranslator.FromHtml(data.color);
            foreach (var item in data.layout)
            {   //颜色更换
                g.FillRectangle(new SolidBrush(myColor), item[0] * SizeWithSpace, item[1] * SizeWithSpace, Size, Size);
            }

            g.EndContainer(containerState);
        }

        public void Move(Direction direction)
        {
            var newPosition = position;
            switch (direction)
            {
                case Direction.Left:
                    newPosition = position with { X = position.X - SizeWithSpace };
                    break;
                case Direction.Right:
                    newPosition = position with { X = position.X + SizeWithSpace };
                    break;
                case Direction.Down:
                    newPosition = position with { Y = position.Y + SizeWithSpace };
                    break;
            }

            if (DetectCollision(newPosition))
            {
                if (direction == Direction.Down)
                {
                    Game.Instance.CombineBrick();
                }
                return;
            }

            position = newPosition;
        }

        public void Rotate()
        {
            if (!data.rotatable)
            {
                return;
            }

            var newLayout = new int[data.layout.Length][];
            for (int i = 0, len = data.layout.Length; i < len; i++)
            {
                var item = data.layout[i];
                newLayout[i] = new[] { -item[1], item[0] };
            }

            if (!DetectCollision(position, newLayout))
            {
                data.layout = newLayout;
            }
        }

        public bool DetectCollision()
        {
            return DetectCollision(position, data.layout);
        }

        private bool DetectCollision(Point position)
        {
            return DetectCollision(position, data.layout);
        }

        private bool DetectCollision(Point position, int[][] layout)
        {
            var detected = false;
            var beyondLowerBound = false;
            var beyondHorizontalBound = false;
            var indexX = position.X / SizeWithSpace;
            var indexY = position.Y / SizeWithSpace;
            var mapData = Game.Instance.data;

            foreach (var item in layout)
            {
                var itemIndexX = indexX + item[0];
                var itemIndexY = indexY + item[1];
                if (itemIndexX < 0 || itemIndexY < 0 || itemIndexX >= mapData.GetLength(0) || itemIndexY >= mapData.GetLength(1))
                {
                    detected = true;
                    beyondHorizontalBound = itemIndexX < 0 || itemIndexX >= mapData.GetLength(0);
                    beyondLowerBound = itemIndexY >= mapData.GetLength(1);
                    break;
                }

                if (mapData[itemIndexX, itemIndexY])
                {
                    detected = true;
                    break;
                }
            }

            if (data.penetrable && !beyondHorizontalBound)
            {
                if (detected)
                {
                    if (penetrateState == PenetrateState.OnGoing)
                    {
                        detected = false;
                        if (beyondLowerBound)
                        {
                            Game.Instance.CreateBrick();
                        }
                    }
                    else if (penetrateState == PenetrateState.NotStart)
                    {
                        penetrateState = PenetrateState.OnGoing;
                        detected = beyondLowerBound;
                    }
                }
                else
                {
                    if (penetrateState == PenetrateState.OnGoing)
                    {
                        penetrateState = PenetrateState.Penetrated;
                    }
                }
            }

            return detected;
        }

        public void Combine()
        {
            var indexX = position.X / SizeWithSpace;
            var indexY = position.Y / SizeWithSpace;
            var mapData = Game.Instance.data;
            foreach (var item in data.layout)
            {
                var itemIndexX = indexX + item[0];
                var itemIndexY = indexY + item[1];
                mapData[itemIndexX, itemIndexY] = true;
            }
        }
    }
}
