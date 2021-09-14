using CoreLib.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Shapes.Lines
{
    public class HorizontalLine : Line
    {
        public HorizontalLine(int x1, int x2, int y)
        {
            if (x1 < 0 || y < 0 || x2 < x1) 
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = x1; i <= x2; i++) Locus.Add(new(i,y));
        }
    }
}
