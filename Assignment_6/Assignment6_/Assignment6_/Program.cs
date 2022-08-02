using System;
using System.Collections.Generic;
using LitwareLib;
using Test;
using Employee_Management;

namespace Assignment6_
{
    public delegate void ShowDataDelegate(EmployeeDesignation employeeDesignation);

    internal class Program
    {
        static void Main(string[] args)
        {           
            ShowDataDelegate show = new ShowDataDelegate(MiddleConnect.showDetails);

            MiddleConnect.SetData(001, "Isan Bain", 10000);
            MiddleConnect.SetData(002, "Dia Roy", 20000);
            MiddleConnect.SetData(003, "Ratul Saha", 30000, 50);
            MiddleConnect.SetData(004, "Nilava Manna", 10000);
            MiddleConnect.SetData(005, "Vikash Prasad", 10000, 100);

            Console.WriteLine("-------Manager Details-------");
            show(EmployeeDesignation.Manager);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------MarketingExecutive Details-------");
            show(EmployeeDesignation.MarketingExecutive);

            Console.ReadLine();
        }
    }
}
