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
            
            Point x = new MapLocation(x: 3, y: 2);

            Point p = x;

            map.OnMap(new MapLocation(0,0));
            Console.WriteLine(map.OnMap(new MapLocation(0, 0)));

            var untitled = 3;
            //--Type checks
            Console.WriteLine("Test: {0}", x is MapLocation);
            Console.WriteLine("See if untitled is an int: {0}", untitled is int);
        }
    }

    
}
