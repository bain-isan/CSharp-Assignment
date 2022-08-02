using System;

namespace Assignment1_5
{
    internal class Program
    {
        private static double PI = 3.14;
        public double Radius { get; set; }
        public double Area { get; set; }
        public double Cir { get; set; }

        private enum CalOption
        {
            Area,
            Circumference
        }

        private void Calculate(int option)
        {
            if(option == (int)CalOption.Area)
            {
                this.Area =  Program.PI * this.Radius * this.Radius;
            }
            else if(option == (int)CalOption.Circumference)
            {
                this.Cir = 2 * Program.PI * this.Radius;
            }
        }


        public double GetValidDouble(string msg = null)
        {
            double result = 0;
            try
            {
                
                do
                {
                    if (msg != null)
                        Console.Write(msg);

                    if (!double.TryParse(Console.ReadLine(), out result) && result >= 0)
                    {
                        Console.WriteLine("Enter a valid number...Try Again...\n");
                        continue;
                    }
                    break;
                } while (true);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Radius = program.GetValidDouble("Enter Radius of the Circle (Cm): ");

            program.Calculate(0);
            program.Calculate(1);

            Show.Print(program.Area, program.Cir);

            Console.ReadLine();
        }
    }
}
