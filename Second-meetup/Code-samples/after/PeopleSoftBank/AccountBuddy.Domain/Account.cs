using System;

namespace AccountBuddy.Domain
{
    public class Account
    {
        public string HolderName { set; get; }
        public string HolderUniqueIdentificationNumber { set; get; }
        public string HolderCurrentAddress { set; get; }
        public string HolderAge { get; set; }
        public decimal RateOfInterest { get; set; }

        public bool IsVerified { get; set; }
        public bool IsClosed { get; set; }
        public bool IsFrozen { get; set; }

        public Guid Id { set; get; }
        public decimal Balance { get; set; }

        public Account()
        {
            this.IsFrozen = false;
            this.IsClosed = false;
            this.IsVerified = false;
        }

        public void Validate()
        {
            if(!string.IsNullOrEmpty(HolderName))
            {
                if(HolderUniqueIdentificationNumber.Length == 5)
                {
                    int result = 0;
                    if(int.TryParse(HolderAge, out result))
                    {
                        // Senior citizen
                        if(result > 60)
                        {
                            RateOfInterest = 8;
                        }
                        else
                        {
                            RateOfInterest = 7;
                        }
                    }
                    else
                    {
                        throw new Exception("Age not in correct format.");
                    }
                }
                else
                {
                    throw new Exception("Identification number should be 8 digit.");
                }
            }
            else
            {
                throw new Exception("Holder name cannot be empty.");
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if(!IsFrozen && !IsClosed)
            {
                // Assume this value is read from DB, right now setting it explicitely to true....

                /* this.IsVerified = SQLDb.Query("select is_verified from account"); */

                if(IsVerified)
                {
                    this.Balance += depositAmount;

                    if (this.IsFrozen == true)
                        IsFrozen = false;
                }
            }
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if(!IsClosed)
            {
                /* this.IsVerified = SQLDb.Query("select is_verified from account"); */

                if(IsVerified)
                {
                    if(IsFrozen)
                    {
                        throw new Exception("Your account is frozen. Contact branch.");
                    }

                    if(Balance < 0 || Balance < withdrawAmount)
                    {
                        throw new Exception("Not enough balance");
                    }

                    Balance -= withdrawAmount;
                }
            }
        }
    }
}
