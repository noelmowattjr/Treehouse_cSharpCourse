using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_classes
{
    //--Sub-class of the Point class
    class MapLocation : Point
    {
        public MapLocation(int x, int y) : base(x,y)    //--base keyword is a reference to Point class
        {

        }
    }
}
