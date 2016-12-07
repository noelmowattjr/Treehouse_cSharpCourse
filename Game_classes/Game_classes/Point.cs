using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_classes
{
    class Point
    {
        public readonly int X;  //--points don't move - made them readonly
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            /*  Cartesian Distance Formula  */

            //--Subract from point X and Y
            int xDiff = X - x;
            int yDiff = Y - y;

            //--Square the Diff variables
            int xDiffSq = xDiff * xDiff;
            int yDiffSq = yDiff * yDiff;

            //--Add the products together
            int sum = xDiffSq + yDiffSq;

            //--Let's square root the sum
            var results = (int) Math.Sqrt(sum); //--since Math.Sqrt returns a double I truncated it as int

            return results;
        }
    }
}
