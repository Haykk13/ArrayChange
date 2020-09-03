using System;

namespace ArrayChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] inputArray = new int[length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write("Enter an element: ");
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Array change number is {arrayChange(inputArray)}!");
            Console.ReadLine();
        }
        static int arrayChange(int[] inputArray)
        {
            int count = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if(inputArray[i] > inputArray[i - 1])
                {
                    continue;
                }
                else
                {
                    while(inputArray[i] <= inputArray[i - 1])
                    {
                        inputArray[i]++;
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
