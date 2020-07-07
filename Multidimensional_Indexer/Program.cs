using System;

namespace Multidimensional_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            TimesTables timesTables = new TimesTables();

            timesTables[0, 0] = 2;
            timesTables[0, 1] = 4;
            timesTables[0, 2] = 6;

            timesTables[1, 0] = 3;
            timesTables[1, 1] = 6;
            timesTables[1, 2] = 9;

            timesTables[2, 0] = 4;
            timesTables[2, 1] = 8;
            timesTables[2, 2] = 12;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", timesTables[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
