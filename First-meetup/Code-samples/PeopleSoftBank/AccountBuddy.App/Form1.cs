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
                if (!string.IsNullOrEmpty(account.HolderName))
                {
                    if (account.HolderUniqueIdentificationNumber.Length == 5)
                    {
                        int result = 0;
                        if (int.TryParse(account.HolderAge, out result))
                        {
                            // Senior citizen
                            if (result > 60)
                            {
                                account.Roi = 8;
                            }
                            else
                            {
                                account.Roi = 7;
                            }
                        }
                        else
                        {
                            throw new Exception("Age not in correct format.");
                        }
                    }
                    else
                    {
                        throw new Exception("Identification number should be 5 digit.");
                    }
                }
                else
                {
                    throw new Exception("Holder name cannot be empty.");
                }
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

            switch (transactionTypeComboBox.SelectedItem)
            {
                case "Deposit":
                    if (!account.IsFrozen && !account.IsClosed)
                    {
                        // Assume this value is read from DB, right now setting it explicitely to true....

                        /* this.IsVerified = SQLDb.Query("select is_verified from account"); */

                        if (account.IsVerified)
                        {
                            account.Balance += Convert.ToDecimal(amountTextBox.Text);

                            if (account.IsFrozen == true)
                                account.IsFrozen = false;
                        }
                        else
                        {
                            string.Format("Account not yet verified.");
                            break;
                        }
                    }
                    depositMoneyStatusLabel.ForeColor = Color.Green;
                    depositMoneyStatusLabel.Text = string.Format("Money deposited. Updated balance : {0}", account.Balance);
                    break;
                case "Withdraw":
                    if (!account.IsClosed)
                    {
                        /* this.IsVerified = SQLDb.Query("select is_verified from account"); */

                        if (account.IsVerified)
                        {
                            if (account.IsFrozen)
                            {
                                depositMoneyStatusLabel.Text = string.Format("Your account is frozen. Contact branch.");
                                break;
                            }

                            if (account.Balance < 0 || account.Balance < Convert.ToDecimal(amountTextBox.Text))
                            {
                                depositMoneyStatusLabel.Text = string.Format("Not enough balance");
                                break;
                            }

                            account.Balance -= Convert.ToDecimal(amountTextBox.Text);
                        }
                    }

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

        private Account GetAccount()
        {
            var selectedAccount = (Guid)accountListComboBox.SelectedValue;
            var account = Accounts.First(a => a.Id == selectedAccount);
            return account;
        }
    }
}
