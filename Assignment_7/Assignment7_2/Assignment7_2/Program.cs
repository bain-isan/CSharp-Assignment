using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Assignment7_3_Bank;

namespace Assignment7_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\C#_Assignments\Assignment_7\Files\Account\AccountDetails.txt";

            Account[] acc= new Account[2];
            acc[0] = new Account(1234567890, "Isan Bain", 15000);
            acc[1] = new Account(1523483123, "Dia Roy", 26000);

            

            StreamWriter streamWriter = new StreamWriter(path, true);

            for(int i =0; i<2; i++)
            {
                streamWriter.WriteLine("A/C No.: " + acc[i].AccountNumber);
                streamWriter.WriteLine("Customer Name.: " + acc[i].CustomerName);
                streamWriter.WriteLine("Balance.: " + acc[i].Balance);
                streamWriter.WriteLine();                
            }
            
            streamWriter.Close();


            StreamReader streamReader = new StreamReader(path);
            while(streamReader.Peek() != -1)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
            Console.Read();
        }
    }
}
