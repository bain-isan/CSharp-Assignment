using System;
using LitwareLib;

namespace Employee_Management
{
    [Serializable]
    public class Manager : Employee
    {
        #region Fields
        double petrolAllowance;
        double foodAllowance;  
        double otherAllowances;
        #endregion

        #region Properties
        public double PetrolAllowance { get { return petrolAllowance; } set { petrolAllowance = value; } }
        public double FoodAllowance { get { return foodAllowance; } set { foodAllowance = value; } }
        public double OtherAllowances { get { return otherAllowances; } set { otherAllowances = value; } }
        #endregion

        #region Override Gross Salary Method
        protected override void CalculateGrossSalary(double HRA_Percent, double TA_Percent, double DA_Percent)
        {
            base.CalculateGrossSalary(HRA_Percent, TA_Percent, DA_Percent);

            this.PetrolAllowance = this.EmpSalary * 0.08;
            this.FoodAllowance = this.EmpSalary * 0.13;
            this.OtherAllowances = this.EmpSalary * 0.03;

            this.GrossSalary += this.PetrolAllowance + this.FoodAllowance + this.OtherAllowances;
        }
        #endregion

        #region Override Net Salary Method
        //protected override void CalculateSalary()
        //{
        //    base.CalculateSalary();
        //    //this.PF = 0.10 * this.GrossSalary;
        //    //this.TDS = 0.18 * this.GrossSalary;
        //    //this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
        //}
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
            Console.WriteLine("Petrol Allowance: {0}", this.PetrolAllowance);
            Console.WriteLine("Food Allowance: {0}", this.FoodAllowance);
            Console.WriteLine("Other Allowances: {0}", this.OtherAllowances);
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
