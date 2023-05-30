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
        private BrickData data;
        public Point position { get; private set; }

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

        public void Paint(Graphics g)
        {
            Paint(g, position, 1);
        }

        public void Paint(Graphics g, Point position, float scale)
        {
            var containerState = g.BeginContainer();

            g.TranslateTransform(position.X, position.Y);
            g.ScaleTransform(scale, scale);

            foreach (var item in data.layout)
            {
                g.FillRectangle(new SolidBrush(Color.Green), item[0] * SizeWithSpace, item[1] * SizeWithSpace, Size, Size);
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
            var indexX = position.X / SizeWithSpace;
            var indexY = position.Y / SizeWithSpace;
            var mapData = Game.Instance.data;

            foreach (var item in layout)
            {
                var itemIndexX = indexX + item[0];
                var itemIndexY = indexY + item[1];
                if (itemIndexX < 0 || itemIndexY < 0 || itemIndexX >= mapData.GetLength(0) || itemIndexY >= mapData.GetLength(1))
                {
                    return true;
                }

                if (mapData[itemIndexX, itemIndexY])
                {
                    return true;
                }
            }

            return false;
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
