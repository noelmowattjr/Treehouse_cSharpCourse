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

            Map map = new Map(width: 8, height: 5);    //--map object
            
            int area = map.Width * map.Height;
            Console.WriteLine("The area is: {0}", area);
        }
    }
}
