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
        public MapLocation(int x, int y, Map map) : base(x,y)    //--base keyword is a reference to Point class
        {
            /*  If point is NOT on the map  */
            if (!map.OnMap(this))   //--the word this is a keyword that refers to current object
            {
                //--Create a new Exception and then throw it
                throw new OutOfBoundsExeption(x+", "+y+" is outside of boundaries of map");
            }
        }
    }
}
