using System;
using Assignment7_3_Bank;

namespace Assignment7_5
{
    internal class Argument : EventArgs
    {
        #region Properties
        public bool Result { get; set; }
        public double WithdrawalBalance { get; set; }
        #endregion

    }

    internal class HDFCBank : Account
    {
        public event EventHandler<Argument> HDFCAccountEvent;

        #region Constructor
        public HDFCBank(long accountNumber, string customerName, double balance) 
            : base(accountNumber, customerName, balance)
        {
        }
        #endregion

        #region Under Balance Event Re-write
        public void UnderBalance(object source, Argument e)
        {
            if (e.WithdrawalBalance < 1000)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of	Rs.-1000");
                e.Result = true;
                return;
            }
            e.Result = false;
        }
        #endregion



        #region Deposit
        public double Deposit(double amount, Argument e)
        {
            Console.WriteLine("{0} Deposit successful", amount);
            Balance += amount;
            HDFCAccountEvent(this, e);
            Console.WriteLine();
            return Balance;
        }
        #endregion



        #region Withdraw
        public bool Withdraw(double amount, Argument e)
        {
            e.WithdrawalBalance = this.Balance - amount;
            HDFCAccountEvent(this, e);

            if(e.Result)
            {
                return false;
            }

            if (this.Balance < amount)
            {
                Console.WriteLine("Balance Insufficient");
                Console.WriteLine();
                return false;
            }
            this.Balance -= amount;
            Console.WriteLine("{0} Withwrawal Successful...", amount);
            Console.WriteLine();
            return true;
        }
        #endregion



        #region Subscribe
        public new void LinkEvent()
        {
            HDFCAccountEvent += this.UnderBalance;
            HDFCAccountEvent += this.ZeroBalance;
        }
        #endregion


        #region Main
        static new void Main(string[] args)
        {
            Argument e = new Argument();
            HDFCBank accountB = new HDFCBank(48952130784, "Isan Bain", 2000);
            accountB.LinkEvent();

            accountB.Withdraw(2000, e);
            accountB.Deposit(100, e);

            accountB.Withdraw(200, e);

            accountB.displayAccount();

            Console.Read();

        }
        #endregion
    }
}
