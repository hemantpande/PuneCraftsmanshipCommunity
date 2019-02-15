using System;

namespace AccountBuddy.Domain
{
    public class Account
    {
        //TODO: New holder class?? May be in improved code example. Right now dumping everything here.
        public string HolderName { private set; get; }
        private string holderUniqueIdentificationNumber;
        private string holderCurrentAddress;

        public bool IsActive { get; private set; }
        public Guid Id { private set; get; }
        public decimal Balance { get; private set; }

        public Account(string holderName, 
                       string holderUniqueIdentificationNumber, 
                       string holderCurrentAddress)
        {
            this.Id = Guid.NewGuid();
            this.HolderName = holderName;
            this.holderUniqueIdentificationNumber = holderUniqueIdentificationNumber;
            this.holderCurrentAddress = holderCurrentAddress;

            this.IsActive = true;
        }

        public void Deposit(decimal depositAmount)
        {
            if(IsActive)
            {
                this.Balance += depositAmount;
            }
        }
    }
}
