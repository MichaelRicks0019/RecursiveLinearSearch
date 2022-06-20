using System;

namespace RecursiveLinearSearch
{
    class Program
    {

        public static int RecursiveLinearSearch(int[] values, int searchKey, int startingIndex)
        {
            int[] valuesTemp = values;
            int searchKeyCounter = searchKey;
            int startingIndexCounter = startingIndex;

            if (values[startingIndex] == searchKey)
            {
                return values[startingIndex];
            }
            else if(startingIndex >= values.Length)
            {
                return -1;
            }
            else
            {
            searchKeyCounter++;
            startingIndexCounter++;
            RecursiveLinearSearch(valuesTemp, searchKeyCounter, startingIndexCounter);
            }
            return -1;
        }

        
        static void Main(string[] args)
        {
            var random = new Random();
            var data = new int[10];
            var searchIndex = 7;

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = random.Next(0, 50);
            }
            
            foreach (int x in data)
            {
                Console.Write(x);
            }
            Console.WriteLine("\n");

            int position = RecursiveLinearSearch(data, searchIndex, 0);

            if (position == -1)
            {
                Console.WriteLine($"int {searchIndex} not found");
            }
            else
            {
                Console.WriteLine($"int {position} found");
            }
        }
    }
}
