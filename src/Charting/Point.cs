using System;
using System.Collections.Generic;
using System.Text;

namespace Charting
{
    public class Point
    {
        private int _x1;
        private int _y1;
        public Point(int X, int Y)
        {
            _x1 = X;
            _y1 = Y;
        }

        public int X { get { return _x1; } set { _x1 = value; } }
        public int Y { get { return _y1; } set { _y1 = value; } }

    }
}
 