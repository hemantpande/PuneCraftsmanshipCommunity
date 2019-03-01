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
        public List<Account> Accounts = new List<Account>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // vars init begins here
            bool fail = false;
            string err = "";
            int result = 0;
            Account acc = new Account();

            //put list of countries in array
            string[] cntriesArray = new[] { "US", "UK", "AUS" };
            // vars init ends here


            acc.Id = Guid.NewGuid();
            acc.Name = nameTextBox.Text;
            acc.Uid = uidTextBox.Text;
            acc.Address = currentAddressTextBox.Text;
            acc.Age = ageTextBox.Text;

            try
            {
                if (!string.IsNullOrEmpty(acc.Name))
                {





                    if (acc.Uid.Length == 5)
                    {



                        if (int.TryParse(acc.Age, out result))
                        {
                            //DFCT #566 Abhijeet 
                            //We're now requiring check for age greater than 60 
                            // so I added check for it. Boy, programming is hard.

                            if (result > 60)
                            {
                                acc.Roi = 8;
                            }
                            else
                            {
                                acc.Roi = 4;
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
                fail = true;
                err = ex.Message;

                if(ex.Message == "Identification number should be 5 digit.")
                {
                    try
                    {
                        //foreach (var item in cntriesToExcludeArray)
                        //{
                        //    if(uidTextBox.Text.Contains(item))
                        //    {
                        //         throw new Exception("Country not supported by bank");
                        //    }
                        //}


                        // service call to check if account is NRI
                        foreach (var item in cntriesArray)
                        {
                            if(uidTextBox.Text.Contains(item))
                            {
                                fail = false;
                            }
                            else
                            {
                                throw new Exception("Country not supported by bank");
                            }
                        }
                    }
                    catch(Exception ex2)
                    {
                        //in case the db call fails 
                    }
                }
            }

            if (fail)
            {
                accountStatuslabel.ForeColor = Color.Red;
                accountStatuslabel.Text = err;
            }
            else
            {
                Accounts.Add(acc);

                accountStatuslabel.ForeColor = Color.Red;
                accountStatuslabel.Text = "Account created successfully.";

                this.nameTextBox.Text = string.Empty;
                this.uidTextBox.Text = string.Empty;
                this.ageTextBox.Text = string.Empty;
                this.currentAddressTextBox.Text = string.Empty;
                accountListComboBox.DataSource = null;
                accountListComboBox.DataSource = Accounts;
                this.accountListComboBox.DisplayMember = nameof(Account.Name);
                this.accountListComboBox.ValueMember = nameof(Account.Id);
            }
        }

        private void depositOrWithdrawButton_Click(object sender, EventArgs e)
        {
            var selectedAccount = (Guid)accountListComboBox.SelectedValue;
            var account = Accounts.First(a => a.Id == selectedAccount);

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
    }
}
