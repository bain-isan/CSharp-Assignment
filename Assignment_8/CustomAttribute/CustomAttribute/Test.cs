using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    internal class Test
    {

        private static void PrintCustomeAttribute(Type type)
        {
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("-----------------Class Name: {0}---------------------\n", type.Name);

            foreach (Attribute attr in attributes)
            {
                if (attr is SoftwareAttribute)
                {
                    SoftwareAttribute att = (SoftwareAttribute)attr;
                    Console.WriteLine("Project Name: " + att.ProjectName);
                    Console.WriteLine("Description: " + att.Description);
                    Console.WriteLine("ClientName: " + att.ClientName);
                    Console.WriteLine("StartedDate: " + att.StartedDate);
                    Console.WriteLine("EndDate: " + att.EndDate);
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Test.PrintCustomeAttribute(typeof(HDFCAccount));
            Test.PrintCustomeAttribute(typeof(ICICIAccount));

            Console.Read();
            
        }
    }
}
