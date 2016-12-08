using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(width: 8, height: 5);    //--map object

            //--Let's see how the Exception works by
            //--creating a point that isn't on the map
            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(Exception)
            {
                Console.WriteLine("That map location is not on the map!");
            }
            
        }
    }

    
}
