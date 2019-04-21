using System;
namespace TreehouseDefense
{
    public class Game
    {
        public static void Main()
        {
            Map map = new Map();

            map.width = 8;
            map.height = 5;

            int area = map.width * map.height;
        }
    }
}
