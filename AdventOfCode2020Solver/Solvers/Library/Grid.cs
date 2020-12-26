using System;

namespace AdventOfCode.Library
{
    public class Grid<T>
    {
        private T[,] _values;

        private readonly int _startX;
        private readonly int _startY;
        private readonly int _width;
        private readonly int _height;

        public int OriginX => _startX;
        public int OriginY => _startY;
        public int Height => _height;
        public int Width => _width;

        public T this[int x, int y]
        {
            get
            {
                if (!IsValidX(x) || !IsValidY(y))
                {
                    throw new Exception($"Index: X is good: ({IsValidX(x)} - Y is good: ({IsValidY(y)})");
                }

                return _values[TranslateX(x), TranslateY(y)];
            }

            set
            {
                if (!IsValidX(x) || !IsValidY(y))
                {
                    throw new Exception($"Index: X is good: ({IsValidX(x)} - Y is good: ({IsValidY(y)})");
                }

                _values[TranslateX(x), TranslateY(y)] = value;
            }
        }

        public Grid(int width, int height, int xStart = 0, int yStart = 0, T defaultVal = default(T))
        {
            if (width <= 0)
            {
                width = 1;
            }

            if (height <= 0)
            {
                height = 1;
            }

            _startX = xStart;
            _startY = yStart;
            _width = width;
            _height = height;

            _values = new T[_width,_height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    _values[x, y] = defaultVal;
                }
            }
        }

        private bool IsValidX(int x)
        {
            return x >= OriginX && x < OriginX + _width;
        }
        private bool IsValidY(int y)
        {
            return y >= OriginY && y < OriginY + _height;
        }

        private int TranslateX(int x)
        {
            return x - OriginX;
        }

        private int TranslateY(int y)
        {
            return y - OriginY;
        }
    }
}