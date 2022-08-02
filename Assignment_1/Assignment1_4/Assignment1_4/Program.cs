using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4
{
    internal class Program
    {
        #region Get Valid Integer  Method
        public static int GetValidInteger(string msg = null)
        {
            int value = 0;
            try
            { 
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a Valid Integer Number...Try Again...\n\n");
                        continue;
                    }
                    break;

                }while (true);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return value;
        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            try
            {
                int num1 = Program.GetValidInteger("Enter First Number: ");
                int num2 = Program.GetValidInteger("Enter Second Number: ");

                Console.WriteLine("\nBefore Swap:");
                SwapInt.PrintSwapValues(num1,num2);

                Console.WriteLine("\nAfter Swap:");
                SwapInt.Swap(ref num1, ref num2);
                SwapInt.PrintSwapValues(num1, num2);

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
