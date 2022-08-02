using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5_1
{
    internal class Program
    {
        public static void Display<T>(T[] arr)
        {
            Console.WriteLine("Elements are: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i+1, arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] ArrayInt = new int[5];
            string[] ArrayString = new string[5];

            Console.WriteLine("Array of Integer--");
            for(int i = 0; i < ArrayInt.Length; i++)
            {
                Console.Write("Enter Element {0}: ", i+1);
                if (!int.TryParse(Console.ReadLine(), out ArrayInt[i]))
                {
                    Console.WriteLine("Enter valid Integer...");
                    i--;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Array of String--");
            for (int i=0; i<ArrayString.Length; i++)
            {
                Console.Write("Enter String No {0}: ", i + 1);
                ArrayString[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("----------------Existing Array------------------");
            Console.WriteLine("Array of Int:");
            Display<int>(ArrayInt);
            Console.WriteLine("Array of String:");
            Display<string>(ArrayString);
            Console.WriteLine();
            Console.WriteLine();

            

            Console.WriteLine("----------------Coppied Array------------------");
            int[] cpyArrayInt = new int[ArrayInt.Length];
            string[] cpyArrayString = new string[ArrayString.Length];
            Array.Copy(ArrayInt, cpyArrayInt, ArrayInt.Length);
            Array.Copy(ArrayString, cpyArrayString, ArrayString.Length);
            Display<int>(cpyArrayInt);
            Display<string>(cpyArrayString);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("----------------Sorted Array------------------");
            Array.Sort<int>(ArrayInt);
            Array.Sort<string>(ArrayString);
            Display<int>(ArrayInt);
            Display<string>(ArrayString);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------Reversed Array------------------");
            Array.Reverse(ArrayInt);
            Array.Reverse(ArrayString);
            Display<int>(ArrayInt);
            Display<string>(ArrayString);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------Cleared Array------------------");
            Array.Clear(ArrayInt, 2, ArrayInt.Length-2);
            Array.Clear(ArrayString, 1, ArrayInt.Length-1);
            Display<int>(ArrayInt);
            Display <string>(ArrayString);

            Console.ReadLine();
        }
    }
}
