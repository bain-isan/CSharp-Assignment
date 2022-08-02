using System;
using System.Collections.Generic;
using Employee_Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Assignment7_4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                MiddleConnect.SetData(001, "Isan Bain", 10000);
                MiddleConnect.SetData(002, "Dia Roy", 20000);
                MiddleConnect.SetData(003, "ABC DEF", 30000);

                List<Manager> manager = MiddleConnect.Managers;
                string path = @"C:\Users\user\Desktop\C#_Assignments\Assignment_7\Files\ManagerData\Manager.txt";
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);


                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, manager);

                manager.Clear();
                fs.Close();
                fs = new FileStream(path,FileMode.Open, FileAccess.Read);
                List<Manager> man = (List<Manager>)bf.Deserialize(fs);

                foreach (Manager m in man)
                {
                    m.PrintDetails();
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            Console.ReadLine();
        }
    }
}
