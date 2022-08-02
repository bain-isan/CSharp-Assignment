using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_3
{
    /// <summary>
    /// This will calculate sum of all element in a integer array...Have static method ArraySum(array)
    /// </summary>
    internal class Calculate
    {
        #region Array Sum Method
        /// <summary>
        /// public static void ArraySum() || 
        /// public static void ArraySum(int[] array) || 
        /// public static void ArraySum(1,2,3,4)
        /// </summary>
        public static void ArraySum(params int[] array)
        {
            Console.WriteLine("\nYour Calculated Sum is: {0}", array.Sum());

        }
        #endregion
    }
}
