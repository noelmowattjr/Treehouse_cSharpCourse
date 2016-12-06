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
    }
}
