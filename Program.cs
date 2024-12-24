using System;
namespace ArrayManipulation
{
    public class StudentCode
    {
        public int[] DoubleArray(int[] numbers)
        {
            int[] results = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                results[i] = numbers[i] * 2;
            }
            return results;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            StudentCode studentCode = new StudentCode();
            int[] results = studentCode.DoubleArray(numbers);
            Console.WriteLine("Results: ");
            foreach (var result in results)
            {
                Console.Write(result + " ");
            }
        }
    }
}
