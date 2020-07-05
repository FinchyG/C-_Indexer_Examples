using System;

namespace StoreIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreLocations StoreArr = new StoreLocations();

            StoreArr[0] = "Halifax";
            StoreArr[1] = "Leeds";
            StoreArr[2] = "Bradford";
            StoreArr[3] = "Huddersfield";

            for (int i = 0; i < 4; i++)
                Console.WriteLine(StoreArr[i]);
        }
    }
}
