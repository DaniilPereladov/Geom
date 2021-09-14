using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
   public struct Point :IDraw
    {
        private const char Symbol = 'X';
        public int X, Y;

        public Point(int x, int y) 
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            SetCursorPosition(X,Y);
            Write(Symbol);
        }

        internal bool IsHit(Point point)
        {
            return X = point.X && Y == point.Y;
        }
    }
}
