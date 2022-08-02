using System;
using System.Collections.Generic;
using LitwareLib;
using Test;

namespace Assignment2_1
{
    internal class RegisterEmployee
    {
        static List<Employee> employees = new List<Employee>();

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
        public static bool TakeInput(Employee emp)
        {
            try
            {
                Console.WriteLine("\n--------------------Register New Employee--------------------");
                int id = RegisterEmployee.GetValidInteger("Enter Employee Number (-1 to exit): ");
                if (id > 0)
                {
                    Console.Write("Enter Employee Name: ");
                    string name = Console.ReadLine();

                    double salary = RegisterEmployee.GetValidDouble("Enter Employee Salary: ");
                
                    emp.SetEmployeeData(id, name, salary);
                    return true;
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

        #region Get Gross Salary Method
        private static void GetGrossSalary(Employee em)
        {
            Console.WriteLine("Gross Salary is: {0}", em.GrossSalary);
        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            try
            {
                bool res;
                Employee emp = null;

                do
                {
                    emp = new Employee();
                    res = RegisterEmployee.TakeInput(emp);
                    if (res)
                    {
                        RegisterEmployee.GetGrossSalary(emp);
                        employees.Add(emp);
                    }
                } while (res);

                Connecter.DisplayDetails(employees);

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
