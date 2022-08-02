using System;
using System.Reflection;
using Assignment8;

namespace Testing
{
    internal class Test
    {
        public static void Main(string[] args)
        {

            //Reflection only can retreve the PUBLIC.

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes(); 


            Console.WriteLine("Assembly Name: " + assembly.GetName());

            foreach(var type in types)
            {
                Console.WriteLine(type.Name);
            }

            

            foreach(var type in types)
            {
                Console.WriteLine("---------------Type Name: {0}---------------", type.Name);
                Console.WriteLine("Methods Number: " + type.GetMethods().Length);
                Console.WriteLine();

                Console.WriteLine("------Fields Name: {0}------", type.Name);
                foreach (var field in type.GetFields())
                {
                    Console.WriteLine(field.Name);
                    
                }

                Console.WriteLine();


                Console.WriteLine("------Methods Name: {0}------", type.Name);
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine(method.Name);
                    //Console.WriteLine(method.Invoke("Isan", "Bain"));
                }

                Console.WriteLine();
                Console.WriteLine();
            }
            
            

            
            Console.ReadLine();
        }
    }
}
