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

            //--New array called favoriteAlbums will be 5 items long
            string[] favorriteAlbums = new string[6];

            //--Add an item
            favorriteAlbums[0] = "Born Sinner";
            favorriteAlbums[1] = "2014 Forrest Hill Drive";
            favorriteAlbums[3] = "Good Kid Mad City";
            favorriteAlbums[4] = "Nothing Was The Same";
            favorriteAlbums[2] = "The Noel Mowatt, Jr. EP";

            

            foreach (string i in favorriteAlbums)
            {
                Console.WriteLine(i+" and array length is "+favorriteAlbums.Length);
            }
            

            /*
            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (OutOfBoundsExeption)
            {
                Console.WriteLine("Unhandled Out of bounds Exception!");
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled Treehous Defense Exception!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhadled Exception!");
            }
            */
        }
    }

    
}
