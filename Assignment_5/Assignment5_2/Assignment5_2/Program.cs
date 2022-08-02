using System;
using System.Collections;
using LitwareLib;
using Test;

namespace Assignment5_2
{
    internal class Program
    {
        static ArrayList arrayList = new ArrayList();
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetEmployeeData(001,"Isan Bain", 10000);
            arrayList.Add(emp);
            
            Employee emp1 = new Employee();
            emp1.SetEmployeeData(002,"Dia Roy", 20000);
            arrayList.Add(emp1);

            Employee emp2 = new Employee();
            emp2.SetEmployeeData(0031, "Nilava Manna", 30000);
            arrayList.Add(emp2);
            
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
