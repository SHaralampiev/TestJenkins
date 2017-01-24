namespace ConsoleTest
{
    public class FibRecursive
    {
        private static int[] _fibNums;

        public static int FibMemoRecursion(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            if (_fibNums == null)
                _fibNums = new int[n];

            if (_fibNums[n - 1] != 0)
                return _fibNums[n - 1];


            return _fibNums[n - 1] = FibMemoRecursion(n - 1) + FibMemoRecursion(n - 2);
        }
    }
}
