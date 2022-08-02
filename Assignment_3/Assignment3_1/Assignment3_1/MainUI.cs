using System;
using System.Collections.Generic;
using Employee_Management;

namespace Assignment3_1
{
    internal class MainUI
    {
        
        #region Get Valid Integer Method
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
                        Console.WriteLine("Enter a valid number...Try Again...");
                        continue;
                    }
                    break;
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
        #endregion

        #region Get Valid Double Method
        public static double GetValidDouble(string msg = null)
        {
            double value = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a valid number...Try Again...");
                        continue;
                    }
                    break;
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
        #endregion

        #region Take Input Method
        public static bool TakeInput(int employeeDesignation)
        {
            try
            {
                double Gross = 0;

                Console.WriteLine("\n--------------------Register New Employee--------------------");
                int id = MainUI.GetValidInteger("Enter Employee Number: ");

                if (id > 0)
                {
                    Console.Write("Enter Employee Name: ");
                    string name = Console.ReadLine();

                    double salary = MainUI.GetValidDouble("Enter Employee Salary: ");
                    
                    if (employeeDesignation == (int)EmployeeDesignation.MarketingExecutive)
                    {
                        double km = MainUI.GetValidDouble("Enter Travelling Distance (Km): ");
                        Gross = MiddleConnect.SetData(id, name, salary, km);
                        Console.WriteLine("Gross Salary Is: {0}", Gross);
                        return true;
                    }

                    else if (employeeDesignation == (int)EmployeeDesignation.Manager)
                    {
                        Gross = MiddleConnect.SetData(id, name, salary);
                        Console.WriteLine("Gross Salary Is: {0}", Gross);
                        return true;
                    }

                    
                }

                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;

        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            try
            {


                int option = -1;

                do
                {
                    option = GetValidInteger("\nEnter Employee Designation--\n1.Manager\n2.MarketingExecutive" +
                        "\n3.Exit\nEnter Option: ");

                    option--;

                    switch (option)
                    {
                        case 0:
                        case 1: MainUI.TakeInput(option);
                            break;

                        case 2: 
                            break;

                        default: Console.WriteLine("Enter a valid Option...");
                            break;
                    }
                        

                } while (option != 2);

                MiddleConnect.showDetails(EmployeeDesignation.Manager);
                MiddleConnect.showDetails(EmployeeDesignation.MarketingExecutive);


                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
