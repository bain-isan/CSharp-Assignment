using System;
using System.Collections.Generic;
using LitwareLib;

namespace Test
{
    public class Connecter
    {

        #region Send Gross Salary
        public static double GetGrossSalary(Employee emp)
        {
            return emp.GrossSalary;
        }
        #endregion

        #region Display Employee Details 
        public static void DisplayDetails(List<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                Display(e);
            }
        }
        
        public static void DisplayDetails(Employee emp)
        {
            Display(emp);
        }

        private static void Display(Employee emp)
        {
            Console.WriteLine("No: {0}", emp.EmployeeNo);
            Console.WriteLine("Name: {0}", emp.EmployeeName);
            Console.WriteLine("Salary: {0}", emp.EmpSalary);
            Console.WriteLine("HRA: {0}", emp.HRA);
            Console.WriteLine("TA: {0}", emp.TA);
            Console.WriteLine("DA: {0}", emp.DA);
            Console.WriteLine("Gross: {0}", emp.GrossSalary);
            Console.WriteLine("PF: {0}", emp.PF);
            Console.WriteLine("TDS: {0}", emp.TDS);
            Console.WriteLine("Net: {0}", emp.NetSalary);
            Console.WriteLine();
        }
        #endregion




        static void Main(string[] args)
        {
        }
    }
}
