using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_6
{
    internal class MyTeam
    {
        static void Main(string[] args)
        {
            Team india = new Team();
            india.Add(new Player("Rohit Sharma", 12345));
            india.Add(new Player("Sikhar Dhawan", 12400));
            india.Add(new Player("Virat Kohli", 15400));
            india.Add(new Player("Surya Kumar Yadav", 1456));
            india.Add(new Player("Rishav Panth", 1900));
            india.Add(new Player("Ishan Kishan", 1000));
            india.Add(new Player("Jasprit Bumrah", 400));

            foreach(Player p in india)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Total Run " + p.RunScored);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
