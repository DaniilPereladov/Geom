using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Shapes.Lines
{
    class HorizontalLine
    {
        public HorizontalLine(int x1, int x2, int y)
        {
            for (int i = x1; i <= x2; i++) Locus.Add(new(x, i));
        }
    }
}
