using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_classes
{
    class Map
    {
        //--Instance variables
        public readonly int Width;  //--readonly - the w and h cannot be changed after they have been created
        public readonly int Height;

        //--Constructor -   construct new instance of this class
        public Map(int width, int height)
        {
            //--Method level variables
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            //--Returns true if in bounds of map otherwise false
            bool inBounds = point.X >= 0 &&  point.X < Width && point.Y >=0 && point.Y < Height;

            bool outOfBounds = point.X < 0 || point.X > Width || point.Y < 0 || point.Y >= Height;

            inBounds = !outOfBounds;

            return inBounds;
        }
    }
}
