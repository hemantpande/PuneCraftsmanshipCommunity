using AccountBuddy.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBuddy.App
{
    public partial class MainForm : Form
    {
        private List<Account> Accounts = new List<Account>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            bool errorEncountered = false;
            string errorMessage = "";
            var account = new Account();
            account.Id = Guid.NewGuid();
            account.HolderName = nameTextBox.Text;
            account.HolderUniqueIdentificationNumber = uidTextBox.Text;
            account.HolderCurrentAddress = currentAddressTextBox.Text;
            account.HolderAge = ageTextBox.Text;

            try
            {
                account.Validate();
            }
            catch (Exception ex)
            {
                errorEncountered = true;
                errorMessage = ex.Message;
            }

            if (errorEncountered)
            {
                accountStatuslabel.ForeColor = Color.Red;
                accountStatuslabel.Text = errorMessage;
            }
            else
            {
                Accounts.Add(account);

                accountStatuslabel.ForeColor = Color.Red;
                accountStatuslabel.Text = "Account created successfully.";

                ResetFields();

                ResetDataSource();
            }
        }

        private void depositOrWithdrawButton_Click(object sender, EventArgs e)
        {
            Account account = GetAccount();

            switch(transactionTypeComboBox.SelectedValue.ToString())
            {
                case "Deposit":
                    DepositMoney(account);
                    depositMoneyStatusLabel.ForeColor = Color.Green;
                    depositMoneyStatusLabel.Text = string.Format("Money deposited. Updated balance : {0}", account.Balance);
                    break;
                case "Withdraw":
                    WithdrawMoney(account);
                    depositMoneyStatusLabel.ForeColor = Color.Green;
                    depositMoneyStatusLabel.Text = string.Format("Money withdrawn. Updated balance : {0}", account.Balance);
                    break;
                default:
                    throw new Exception("Operation not supported.");
            }
        }

        private void WithdrawMoney(Account account)
        {
            account.Withdraw(Convert.ToDecimal(amountTextBox.Text));
        }

        private void ResetFields()
        {
            this.nameTextBox.Text = string.Empty;
            this.uidTextBox.Text = string.Empty;
            this.ageTextBox.Text = string.Empty;
            this.currentAddressTextBox.Text = string.Empty;
        }

        private void ResetDataSource()
        {
            accountListComboBox.DataSource = null;
            accountListComboBox.DataSource = Accounts;
            this.accountListComboBox.DisplayMember = nameof(Account.HolderName);
            this.accountListComboBox.ValueMember = nameof(Account.Id);
        }

        private void DepositMoney(Account account)
        {
            account.Deposit(Convert.ToDecimal(amountTextBox.Text));
        }

        private Account GetAccount()
        {
            var selectedAccount = (Guid)accountListComboBox.SelectedValue;
            var account = Accounts.First(a => a.Id == selectedAccount);
            return account;
        }
    }
}
