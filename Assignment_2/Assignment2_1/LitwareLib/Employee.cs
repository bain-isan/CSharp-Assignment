using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    [Serializable]
    public class Employee
    {
        #region Fields
        //private static Employee[] employee = null;

        private int empNo;
        private string empName;
        private double salary;
        private double hRA;
        private double tA;
        private double dA;
        private double pF;
        private double tDS;
        private double netSalary;
        private double grossSalary;
        #endregion

        #region Properties
        public int EmployeeNo { get { return this.empNo; } set { this.empNo = value; } }

        public string EmployeeName { get { return this.empName; } set { this.empName = value; } }

        public double EmpSalary { get { return this.salary; } set { this.salary = value; } }

        public double GrossSalary { 
            get { return this.grossSalary; }
            set
            {
                this.grossSalary = value;
            } 
        }

        public double HRA { 
            get { return this.hRA; }
            set
            {
                this.hRA = value;
            }
        }
        public double TA { 
            get { return this.tA; }
            set
            {
                this.tA = value;
            }
        }
        public double DA { 
            get { return this.dA; }
            set
            {
                this.dA = value;
            }
        }
        public double PF { 
            get { return this.pF; }
            set
            {
                this.pF = value;
            } 
        }
        public double TDS { 
            get { return this.tDS; }
            set
            {
                this.tDS = value;
            }
        }
        public double NetSalary { get { return this.netSalary; }
            set
            {
                this.netSalary = value;
            }
        }

        #endregion

        #region Calculate PF TDS Net Method
        protected virtual void CalculateSalary()
        {
            this.PF = this.GrossSalary * 0.10;
            this.TDS = this.GrossSalary * 0.18;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
        }
        #endregion

        #region Calculate HRA TA DA method
        protected virtual void CalculateGrossSalary(double HRA_Percent, double TA_Percent, double DA_Percent)
        {
            this.HRA = this.EmpSalary * (HRA_Percent / 100);
            this.TA = this.EmpSalary * (TA_Percent / 100);
            this.DA = this.EmpSalary * (DA_Percent / 100);
            this.GrossSalary = this.EmpSalary + this.HRA + this.TA + this.DA;
        }
        #endregion

        #region Set Employee Data Method
        
        public void SetEmployeeData(int EmpNo, string EmpName, double Salary)
        {


            this.EmployeeNo = EmpNo;
            this.EmployeeName = EmpName;
            this.EmpSalary = Salary;

            if (Salary < 5000)
            {
                this.CalculateGrossSalary(10, 5, 15);
                this.CalculateSalary();

            }
            else if (Salary < 10000)
            {
                this.CalculateGrossSalary(15, 10, 20);
                this.CalculateSalary();

            }
            else if (Salary < 15000)
            {
                this.CalculateGrossSalary(20, 15, 25);
                this.CalculateSalary();

            }
            else if (Salary < 20000)
            {
                this.CalculateGrossSalary(25, 20, 30);
                this.CalculateSalary();

            }
            else
            {
                this.CalculateGrossSalary(30, 25, 35);
                this.CalculateSalary();
            }

            
        }
        
        #endregion

    }
}
