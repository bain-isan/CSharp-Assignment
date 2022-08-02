using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_3
{
    
    internal class Program
    {
        #region Get Valid Integer Number Method
        public static int GetValidInt(string msg = null)
        {
            int number;
            do
            {
                if(msg != null)
                    Console.Write(msg);

                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                Console.WriteLine("Enter a valid Number...Try Again...\n\n");
            } while (true);

            return number;
        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            int size;
            int[] array = null;
            size = Program.GetValidInt("Enter Number of Elements you want to Insert: ");

            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Program.GetValidInt("Enter Element No " + (i + 1) + " :");
            }

            Calculate.ArraySum(array);

            Console.ReadLine();
        }
    }
    #endregion
}
