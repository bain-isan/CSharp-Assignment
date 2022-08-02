using System;
using System.Collections.Generic;
using LitwareLib;
using Test;

namespace Assignment5_3
{
    internal class Program
    {
        static List<Employee> list = new List<Employee>();
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetEmployeeData(011, "Isan Bain", 20000);
            list.Add(emp);

            Employee emp1 = new Employee();
            emp1.SetEmployeeData(052, "Dia Roy", 25000);
            list.Add(emp1);

            Employee emp2 = new Employee();
            emp2.SetEmployeeData(0191, "Nilava Manna", 65000);
            list.Add(emp2);

            Connecter.DisplayDetails(emp);
            Console.WriteLine();
            Console.WriteLine();
            Connecter.DisplayDetails(emp1);
            Console.WriteLine();
            Console.WriteLine();
            Connecter.DisplayDetails(emp2);

            Console.ReadLine();
        }
    }
}
