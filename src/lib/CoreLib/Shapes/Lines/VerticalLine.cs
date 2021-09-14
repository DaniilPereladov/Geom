using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Shapes.Lines
{
    public class VerticalLine: Line
    {
        public VerticalLine(int x, int y1,int y2)
        {
            for (int i = y1; i <= y2; i++) Locus.Add(new(x, i));
        }
    }
}
