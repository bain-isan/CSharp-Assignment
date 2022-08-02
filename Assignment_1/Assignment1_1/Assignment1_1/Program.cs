/*
 * 1.	Write a Simple console Application Calculator with the help of Visual Studio .NET IDE 
 *      which will perform following operations on two numbers:
 *          a.	Addition.
 *          b.	Subtraction.
 *          c.	Multiplication.
 *          d.	Division
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_1
{
    internal class Program
    {
        #region Fields
        private double firstNumber;
        private double secondNumber;
        private double result;
        #endregion


        #region Properties
        public double FirstNumber
        {
            get
            {
                return firstNumber;
            }
            
        }


        public double SecondNumber
        {
            get
            {
                return secondNumber;
            }
            
        }

        public double Result
        {
            get
            {
                return result;
            }
        }
        #endregion


        #region Addition Method
        public void Addition()
        {
            this.result = this.FirstNumber + this.SecondNumber;
        }
        #endregion


        #region Subtraction Method
        public void Subtraction()
        {
            this.result = this.FirstNumber - this.SecondNumber;
        }
        #endregion


        #region Multiplication Method
        public void Multiplication()
        {
            this.result = this.FirstNumber * this.SecondNumber;
        }
        #endregion


        #region Division Method
        public void Division()
        {
            this.result = this.FirstNumber / this.SecondNumber;
        }
        #endregion


        #region Take User Input
        private bool TakeUserInput()
        {
            double num1 = 0;
            double num2 = 0;
            
            try
            {

                Console.Write("\nEnter First Number: ");

                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Some error occurs. Try Again...");
                    num2 = 0;
                    return false;
                }

                Console.Write("Enter Second Number: ");

                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Some error occurs. Try Again...");
                    num1 = 0;
                    return false;
                }
                this.firstNumber = num1;
                this.secondNumber = num2;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        #endregion


        #region Show Result
        private void ShowResult()
        {
            Console.WriteLine("Calculated Result is: {0}\n\n", this.Result);
        }
        #endregion


        #region Main Method
        static void Main(string[] args)
        {
            try
            {
                int option;
                do
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
                    Console.Write("Choose Option (Enter -1 to exit): ");

                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Some error occurs. Try Again...");
                        continue;
                    }


                    Program program = new Program();
                    
                    switch (option)
                    {
                        case 1:
                            
                            if (!program.TakeUserInput())
                            {
                                Console.WriteLine("Something Went Wrong..Try Again...");
                                continue;
                            }
                            program.Addition();
                            program.ShowResult();
                            break;

                        case 2:
                            
                            if (!program.TakeUserInput())
                            {
                                Console.WriteLine("Something Went Wrong..Try Again...");
                                continue;
                            }
                            program.Subtraction();
                            program.ShowResult();
                            break;

                        case 3:
                            
                            if (!program.TakeUserInput())
                            {
                                Console.WriteLine("Something Went Wrong..Try Again...");
                                continue;
                            }
                            program.Multiplication();
                            program.ShowResult();
                            break;

                        case 4:

                            if (!program.TakeUserInput())
                            {
                                Console.WriteLine("Something Went Wrong..Try Again...");
                                continue;
                            }
                            if (program.SecondNumber == 0)
                            {
                                Console.WriteLine("Denominator Cannot be Zero. Try Again..");
                                continue;
                            }
                            program.Division();
                            program.ShowResult();
                            break;

                        default: Console.WriteLine("Please Choose a valid Option...\n\n");
                            break;
                    }
                } while (option != -1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}