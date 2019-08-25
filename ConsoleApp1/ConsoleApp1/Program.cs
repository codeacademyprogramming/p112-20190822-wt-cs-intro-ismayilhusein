using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededleri daxil edin");
            string line = Console.ReadLine();

            string[] strArray = line.Split(' ');

            int[] numbers = Array.ConvertAll(strArray, int.Parse);

            Console.WriteLine("En boyuk eded: " + findMaxNumber(numbers));
            Console.WriteLine("En kicik eded: " + findMinNumber(numbers));
            Console.WriteLine("Ededlerin cemi: " + findSum(numbers));

            int[] reversedArray = reverseArray(numbers);

            for(int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }

            Console.ReadLine();
        }

        static int findMaxNumber(int[] array)
        {
            Console.WriteLine(name);
            return array.Max();
        }

        static int findMinNumber(int[] array)
        {
            return array.Min();
        }

        static int findSum(int[] array)
        {
            return array.Sum();
        }

        static int[] reverseArray(int[] array)
        {
            int[] temp = array;
            Array.Reverse(temp);
            return temp;
        }
    }
}
