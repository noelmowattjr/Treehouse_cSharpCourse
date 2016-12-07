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
            
            Point point = new Point(x: 8, y: 2);
            
            //--Shows us the distance between points 8,2 -and- 5,5
            Console.WriteLine(point.DistanceTo(5, 5));  //-- Prints // 4
            
        }
    }

    
}
