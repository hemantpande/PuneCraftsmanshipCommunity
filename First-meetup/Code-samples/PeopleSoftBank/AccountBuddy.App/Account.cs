using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBuddy.App
{
    public class Account
    {
        public string HolderName { set; get; }
        public string HolderUniqueIdentificationNumber { set; get; }
        public string HolderCurrentAddress { set; get; }
        public string HolderAge { get; set; }
        public decimal Roi { get; set; }

        public bool IsVerified { get; set; }
        public bool IsClosed { get; set; }
        public bool IsFrozen { get; set; }

        public Guid Id { set; get; }
        public decimal Balance { get; set; }

        public Account()
        {
            this.IsFrozen = false;
            this.IsClosed = false;
            this.IsVerified = true;
        }

        public void Deposit(decimal depositAmount)
        {
            if (!IsFrozen && !IsClosed)
            {
                // Assume this value is read from DB, right now setting it explicitely to true....

                /* this.IsVerified = SQLDb.Query("select is_verified from account"); */

                if (IsVerified)
                {
                    this.Balance += depositAmount;

                    if (this.IsFrozen == true)
                        IsFrozen = false;
                }
            }
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (!IsClosed)
            {
                /* this.IsVerified = SQLDb.Query("select is_verified from account"); */

                if (IsVerified)
                {
                    if (IsFrozen)
                    {
                        throw new Exception("Your account is frozen. Contact branch.");
                    }

                    if (Balance < 0 || Balance < withdrawAmount)
                    {
                        throw new Exception("Not enough balance");
                    }

                    Balance -= withdrawAmount;
                }
            }
        }
    }
}
