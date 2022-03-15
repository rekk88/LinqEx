using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsSquare(int n)
            {
                return Math.Sqrt(n) % 1 == 0;
            }

            IsSquare(4);
        }
    }
}
