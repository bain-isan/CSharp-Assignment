using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    internal class MaxAvgCalculation
    {
        #region Fields
        private double[] avgMarks;
        #endregion

        #region Average Marks Calculation
        public double[] AvgMarks
        {
            get { return avgMarks; }
            set { avgMarks = value; }
            
        }
        #endregion

        #region Result Calculate and Shown
        public void MaxResult()
        {
            double res = AvgMarks.Max();
            Console.WriteLine("Maximum Avg is: {0}", res);
            Console.WriteLine("Oprained By Student Number {0}", Array.IndexOf(AvgMarks, res) + 1);
            Console.ReadLine();
        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            try
            {
                double[] avg = new double[5];
                MaxAvgCalculation program = new MaxAvgCalculation();
                Console.WriteLine("Enter Average Marks:");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Student {0}: ", i+1);
                    if(!double.TryParse(Console.ReadLine(), out avg[i]))
                    {
                        Console.WriteLine("Enter a valid Number.. Try Again...\n");
                        i--;
                        continue;
                    }
                    
                    Console.WriteLine();
                }

                program.AvgMarks = avg;
                program.MaxResult();


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
