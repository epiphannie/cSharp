using System;

namespace TreehouseDefense
{
    public class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefense Exception");
            }
            catch(Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }

        }
    }
}
