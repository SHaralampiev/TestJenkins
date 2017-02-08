using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public static class DFSearch
    {
        private const int WALL = 1;
        private const int EXIT = 2;
        private const int PATH = 0;
        private const int VISITED = -1;


        public static List<Point[]> Search(int[,] labirint, Point startingPoint)
        {
            var allPaths = new List<Point[]>();

            Search(labirint, startingPoint, new Stack<Point>(), allPaths);
            
            return allPaths;
        }

        private static void Search(int[,] labirint, Point currentLocation, Stack<Point> currentPath, List<Point[]> allPaths)
        {
            try
            {
                if (labirint[currentLocation.X, currentLocation.Y] == WALL ||
                    labirint[currentLocation.X, currentLocation.Y] == VISITED)
                {
                    return;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }

            currentPath.Push(currentLocation);

            if (labirint[currentLocation.X, currentLocation.Y] == EXIT)
            {
                allPaths.Add(currentPath.Reverse().ToArray());
                currentPath.Pop();
                return;
            }

            labirint[currentLocation.X, currentLocation.Y] = VISITED;


            Search(labirint, new Point() {X = currentLocation.X + 1, Y = currentLocation.Y}, currentPath, allPaths);
            Search(labirint, new Point() {X = currentLocation.X - 1, Y = currentLocation.Y}, currentPath, allPaths);
            Search(labirint, new Point() {X = currentLocation.X, Y = currentLocation.Y + 1}, currentPath, allPaths);
            Search(labirint, new Point() {X = currentLocation.X, Y = currentLocation.Y - 1}, currentPath, allPaths);

            labirint[currentLocation.X, currentLocation.Y] = VISITED;
            currentPath.Pop();
        }
    }
}
