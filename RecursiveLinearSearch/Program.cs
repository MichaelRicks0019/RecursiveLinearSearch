
using System;

namespace RecursiveLinearSearch
{
    class Program
    {

        

        public static void RunRecursiveLinearSearch()
        {

            var random = new Random();
            var data = new int[10];
            int searchIndex;

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = random.Next(0, 50);
            }

            foreach (int x in data)
            {
                Console.Write($"{x}, ");
            }
            Console.WriteLine("\n");

            Console.Write("Enter number to search for: ");
            searchIndex = int.Parse(Console.ReadLine());

            int position = RecursiveLinearSearch(data, searchIndex, 0);

            if (position == -1)
            {
                Console.WriteLine($"int {searchIndex} not found");
            }
            else
            {
                Console.WriteLine($"int {position} found");
            }


            static int RecursiveLinearSearch(int[] values, int searchKey, int startingIndex)
            {

                if (values[startingIndex] == searchKey)
                {
                    return values[startingIndex];
                }
                if (startingIndex >= values.Length - 1)
                {
                    return -1;
                }
            
                return RecursiveLinearSearch(values, searchKey, startingIndex + 1);
                
               
            }
        }

        
        static void Main(string[] args)
        {
            RunRecursiveLinearSearch();
            int response = 0;
            while (response != -1)
            {
                Console.WriteLine("Enter -1 to Exit and 1 to Search Again");
                response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Console.WriteLine("\n");
                    RunRecursiveLinearSearch();
                }
                else if (response != -1)
                {
                    Console.WriteLine("Incorrect response entered...Try again");
                }
            }
            Console.ReadLine();

        }
    }
}
