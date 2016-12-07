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

            //--Testing concept i just learned
            Console.Write("Enter your age: ");
            string entry = Console.ReadLine();
            int age;

            while (!(int.TryParse(entry, out age)))
            {
                Console.Write("Invalid! Enter your age: ");
                entry = Console.ReadLine();
            }

            Console.Write("Enter your friend's age: ");
            string entry2 = Console.ReadLine();
            int age2;

            while (!(int.TryParse(entry2, out age2)))
            {
                Console.Write("Invalid! Enter your age: ");
                entry2 = Console.ReadLine();
            }

            //--Call function
            var decision = IsOldEnough(age, age2);

            if (decision == true)
                Console.WriteLine("You may enter the establishment!");

            if (decision != true)
                Console.WriteLine("You aren't old enough! Sorry.");

        }

        public static bool IsOldEnough(int Age, int Age2)
        {
            bool isAdult = Age >= 21 && Age2 >=21;

            return isAdult;
        }
    }
}
