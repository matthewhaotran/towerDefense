using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 8);
            Console.WriteLine("The area of the map is " + map.Height * map.Width + " square feet");
        }
    }
}
