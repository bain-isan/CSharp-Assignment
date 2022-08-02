using System;
using Assignment7_3_Bank;

namespace Assignment7_4
{
    
    internal class ICICIBank : Account
    {
        public event EventHandler ICICIAccountEvent;

        public ICICIBank(long accountNumber, string customerName, double balance) : base(accountNumber, customerName, balance)
        {
        }


        #region Under Balance Event Re-write
        public override void UnderBalance(object source, EventArgs e)
        {
            if (((Account)source).Balance < 500)
            {
                Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
            }
        }
        #endregion

        #region Deposit
        public new double Deposit(double amount)
        {
            Console.WriteLine("{0} Deposit successful", amount);
            Balance += amount;
            ICICIAccountEvent(this, EventArgs.Empty);
            Console.WriteLine();
            return Balance;
        }
        #endregion

        #region Withdraw
        public new bool Withdraw(double amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Balance Insufficient");
                ICICIAccountEvent(this, EventArgs.Empty);
                Console.WriteLine();
                return false;
            }
            this.Balance -= amount;
            Console.WriteLine("{0} Withwrawal Successful...", amount);
            ICICIAccountEvent(this, EventArgs.Empty);
            Console.WriteLine();
            return true;
        }
        #endregion

        #region Subscribe
        public new void LinkEvent()
        {
            ICICIAccountEvent += this.UnderBalance;
            ICICIAccountEvent += this.ZeroBalance;
        }
        #endregion

        static new void Main(string[] args)
        {
            ICICIBank accountB = new ICICIBank(48952130784, "Isan Bain", 2000);
            accountB.LinkEvent();

            accountB.Withdraw(2000);
            accountB.Deposit(100);

            accountB.Withdraw(200);

            accountB.displayAccount();

            Console.Read();

        }
    }
}
