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
            AddAccount();

            PrintMessage(this.accountStatuslabel, "Account created successfully.");

            ResetFields();

            ResetDataSource();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            Account account = GetAccount();

            DepositMoney(account);

            PrintMessage(depositMoneyStatusLabel, string.Format("Money deposited. Updated balance : {0}", account.Balance));
        }

        private void AddAccount()
        {
            var account = new Account(nameTextBox.Text, uidTextBox.Text, currentAddressTextBox.Text);
            Accounts.Add(account);
        }

        private void PrintMessage(Label label, string message)
        {
            label.ForeColor = Color.Green;
            label.Text = message;
        }

        private void ResetFields()
        {
            this.nameTextBox.Text = string.Empty;
            this.uidTextBox.Text = string.Empty;
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
            account.Deposit(Convert.ToDecimal(depositAmountTextBox.Text));
        }

        private Account GetAccount()
        {
            var selectedAccount = (Guid)accountListComboBox.SelectedValue;
            var account = Accounts.First(a => a.Id == selectedAccount);
            return account;
        }
    }
}
