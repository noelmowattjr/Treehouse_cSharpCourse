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

            /*  Our map is 8 units wide and 5 units high    
                let's print the result to the console
                by calling our OnMap method and pass in our point argument */
            Point point = new Point(x: 8, y: 2);
            bool results = map.OnMap(point);

            Console.WriteLine("point = {0}", results);

            Program prog = new Program();
            
            //--Static method
            Program.Sum_Static(9,1);    //--Can be called in the class directly
            Sum_Static(10,5);           //--Or not

            //--Non-Static method
            prog.Sum_Non_Static(20,5);  //--Can ONLY be called onto an instance of a class
            
            
        }
        //--Static
        public static int Sum_Static(int a, int b)
        {
            return a + b;
        }

        //--Non-Static
        public int Sum_Non_Static(int a, int b)
        {
            return a + b;
        }
    }

    
}
