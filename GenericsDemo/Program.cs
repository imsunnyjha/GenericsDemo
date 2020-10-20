using System;
using System.ComponentModel;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4 };
            char[] charArray = { 'A', 'B', 'h', 'F' };

            new PrintArray<int>(intArray).ToPrint();
            new PrintArray<double>(doubleArray).ToPrint();
            new PrintArray<char>(charArray).ToPrint();
        }
    }
    public class PrintArray<TType>
    {
        private TType[] inputArray;
        public PrintArray(TType[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("*********************");
        }
    }
}
