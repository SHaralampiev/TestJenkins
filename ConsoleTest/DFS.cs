using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class DFS
    {
        public static void DFSearch(int[,] labirint, List<Point[]> paths, Point currentLocation)
        {

        }

        public static List<Point[]> DFSearch(int[,] labirint)
        {
            var paths = new List<Point[]>();
            DFSearch(labirint, paths, new Point() { X = 0, Y = 0 });

            return paths;
        }
    }
}
