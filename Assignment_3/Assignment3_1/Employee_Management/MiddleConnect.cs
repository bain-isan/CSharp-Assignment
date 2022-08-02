using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management
{
    public class MiddleConnect
    {
        static List<Manager> managers = new List<Manager>();
        static List<MarketingExecutive> marketingExecutives = new List<MarketingExecutive>();

        #region Properties
        public static List<Manager> Managers { get { return managers; } }
        #endregion


        #region SettingData
        /// <summary>
        /// Enter Data for Manager 
        /// </summary>
        /// <param name="EmpNo"></param>
        /// <param name="EmpName"></param>
        /// <param name="Salary"></param>
        public static double SetData(int EmpNo, string EmpName, double Salary)
        {
            Manager m = new Manager();
            m.SetEmployeeData(EmpNo, EmpName, Salary);
            managers.Add(m);
            return m.GrossSalary;
        }

        /// <summary>
        /// Enter Data For Marketing Executive
        /// </summary>
        /// <param name="EmpNo"></param>
        /// <param name="EmpName"></param>
        /// <param name="Salary"></param>
        /// <param name="kmTravel"></param>
        public static double SetData(int EmpNo, string EmpName, double Salary, double kmTravel)
        {
            MarketingExecutive me = new MarketingExecutive();
            me.SetEmployeeData(EmpNo, EmpName, Salary, kmTravel);
            marketingExecutives.Add(me);
            return me.GrossSalary;
        }
        #endregion

        #region Print Details
        public static void showDetails(EmployeeDesignation type)
        {
            try
            {
                switch (type)
                {
                    case EmployeeDesignation.Manager:
                        {
                            if (managers.Count < 0)
                            {
                                Console.WriteLine("No Records...");
                                return;
                            }
                            foreach (Manager m in managers)
                                m.PrintDetails();
                        }
                        break;

                    case EmployeeDesignation.MarketingExecutive:
                        {
                            Console.WriteLine(managers.Count);
                            if (managers.Count < 0)
                            {
                                Console.WriteLine("No Records...");
                                return;
                            }
                            foreach (MarketingExecutive m in marketingExecutives)
                                m.PrintDetails();
                        }
                        break;

                    default:
                        throw new ArgumentException("Enter a valid Option...");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }

    #region Employee Designation
    public enum EmployeeDesignation
    {
        Manager,
        MarketingExecutive
    }
    #endregion
}
