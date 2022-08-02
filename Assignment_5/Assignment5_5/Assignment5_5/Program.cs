using System;
using System.Collections.Generic;
using LitwareLib;
using Test;

namespace Assignment5_3
{
    internal class Program
    {
        static List<Employee> list = new List<Employee>();
        
        public static int Search(string str)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (str.Equals(list[i].EmployeeName)){
                    Console.WriteLine("Record Found at Object No {0}",i+1);
                    return i;
                }
            }
            Console.WriteLine("Record Not Found...");
            return -1;
        }

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

            Console.WriteLine("--------All Records--------");
            Connecter.DisplayDetails(emp);
            Console.WriteLine();
            Console.WriteLine();
            Connecter.DisplayDetails(emp1);
            Console.WriteLine();
            Console.WriteLine();
            Connecter.DisplayDetails(emp2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------Search Result for \"Dia Roy\" and \"Rimli\"--------");
            //Find "Dia Roy" 
            Program.Search("Dia Roy");

            //Find "Rimli" Result Not Matched
            Program.Search("Rimli");
            

            Console.ReadLine();
        }
    }
}
