using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4
{
    /// <summary>
    /// This can swap two integer. we have to pass ref of two int and also can print number by PrintSwapValues
    /// </summary>
    internal class SwapInt
    {
        #region Swap Method
        public static void Swap(ref int num1, ref int num2)
        {
            num1 += num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }

        #endregion

        #region Print Swap Value Method
        public static void PrintSwapValues(int num1, int num2)
        {
            try
            {
                Console.WriteLine("Number1: {0}", num1);
                Console.WriteLine("Number2: {0}", num2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
