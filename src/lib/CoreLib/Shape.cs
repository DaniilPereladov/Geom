using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public abstract class Shape : IDraw, IEnumerable<Point>
    {
        protected virtual IList<Point> Locus { get; init; } = new List<Point>();
        public void Draw()
        {
            foreach (Point point in Locus) point.Draw();
        }

        public IEnumerator<Point> GetEnumerator() => Locus.GetEnumerator();
        

        IEnumerator IEnumerable.GetEnumerator() => Locus.GetEnumerator();
       
        
    }
}
