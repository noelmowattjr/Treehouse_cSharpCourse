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
            Tower tower = new Tower();  //--new tower instance aka new tower object

            Map map = new Map();    //--map object

            /*  Demonstrating the difference between "public" and "private" access modifiers    */
            //--Access Width & Height field in Map class - then assign both a value
            map.Width = 8;
            map.Height = 5;

            int area = map.Width * map.Height;
            Console.WriteLine("The area is: {0}", area);
        }
    }
}
