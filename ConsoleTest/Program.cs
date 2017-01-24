using System;

namespace ConsoleTest
{
    internal class Program
    {
        private static void Main()
        {
            var ob = new MSMQDemo();
            ob.ProcessMsgs();


            Console.WriteLine(FibRecursive.FibMemoRecursion(6));


            Console.ReadKey();
        }
    }
}