using System;
using System.Collections.Generic;

namespace Employee_Management
{
    [Serializable]
    public class MarketingExecutive : Manager, IPrintable
    {
        #region Fields
        double kmTravel;
        double tourAllowance; // Rs: 5/- per km
        double telephoneAllowance = 1000; // Rs: 1000/-
        #endregion

        #region Properties
        public double KmTravel { get { return kmTravel; } set { kmTravel = value; } }
        public double TourAllowance { get { return tourAllowance; } set { tourAllowance = value; } }
        public double TelephoneAllowance { get { return telephoneAllowance; } }
        #endregion

        #region Override Gross Calculation 
        protected override void CalculateGrossSalary(double HRA_Percent, double TA_Percent, double DA_Percent)
        {
            base.CalculateGrossSalary(HRA_Percent, TA_Percent, DA_Percent);
            this.TourAllowance = this.KmTravel * 5;
            this.GrossSalary += this.TourAllowance + this.TelephoneAllowance;
        }
        #endregion

        #region SetEmployee Data to take Km Travel
        public void SetEmployeeData(int EmpNo, string EmpName, double Salary, double kmTravel)
        {
            this.KmTravel = kmTravel;
            base.SetEmployeeData(EmpNo, EmpName, Salary);
        }
        #endregion

        #region PrintDetails Implement from IPrintable
        public void PrintDetails()
        {
            Console.WriteLine("-----------------------Employment Details of {0}----------------------", this.EmployeeName);
            Console.WriteLine("Personal Details:-----------");
            Console.WriteLine("No: {0}", this.EmployeeNo);
            Console.WriteLine("Name: {0}", this.EmployeeName);
            Console.WriteLine("Salary: {0}", this.EmpSalary);
            Console.WriteLine();

            Console.WriteLine("Allowance Details:-----------");
            Console.WriteLine("HRA: {0}", this.HRA);
            Console.WriteLine("TA: {0}", this.TA);
            Console.WriteLine("DA: {0}", this.DA);
            Console.WriteLine("Tour Allowance {0} Km: {1}", this.KmTravel, this.TourAllowance);
            Console.WriteLine("Telephone Allowance: {0}", this.TelephoneAllowance);
            Console.WriteLine("Gross: {0}", this.GrossSalary);
            Console.WriteLine();

            Console.WriteLine("Deduction Details:-----------");
            Console.WriteLine("PF: {0}", this.PF);
            Console.WriteLine("TDS: {0}", this.TDS);
            Console.WriteLine("Net: {0}", this.NetSalary);
            Console.WriteLine();
        }
        #endregion
    }
}
