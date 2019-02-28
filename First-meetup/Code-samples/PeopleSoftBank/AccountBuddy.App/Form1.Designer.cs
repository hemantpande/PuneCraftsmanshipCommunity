

namespace AccountBuddy.App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.homePageTabControl = new System.Windows.Forms.TabControl();
            this.createAccountTabPage = new System.Windows.Forms.TabPage();
            this.accountStatuslabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.currentAddressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.uidLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.depositMoneyTabPage = new System.Windows.Forms.TabPage();
            this.depositMoneyStatusLabel = new System.Windows.Forms.Label();
            this.accountListComboBox = new System.Windows.Forms.ComboBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.depositOrWithdrawButton = new System.Windows.Forms.Button();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.ageLable = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homePageTabControl.SuspendLayout();
            this.createAccountTabPage.SuspendLayout();
            this.depositMoneyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // homePageTabControl
            // 
            this.homePageTabControl.Controls.Add(this.createAccountTabPage);
            this.homePageTabControl.Controls.Add(this.depositMoneyTabPage);
            this.homePageTabControl.Location = new System.Drawing.Point(25, 26);
            this.homePageTabControl.Name = "homePageTabControl";
            this.homePageTabControl.SelectedIndex = 0;
            this.homePageTabControl.Size = new System.Drawing.Size(747, 394);
            this.homePageTabControl.TabIndex = 0;
            // 
            // createAccountTabPage
            // 
            this.createAccountTabPage.Controls.Add(this.ageTextBox);
            this.createAccountTabPage.Controls.Add(this.ageLable);
            this.createAccountTabPage.Controls.Add(this.accountStatuslabel);
            this.createAccountTabPage.Controls.Add(this.createAccountButton);
            this.createAccountTabPage.Controls.Add(this.currentAddressTextBox);
            this.createAccountTabPage.Controls.Add(this.addressLabel);
            this.createAccountTabPage.Controls.Add(this.uidTextBox);
            this.createAccountTabPage.Controls.Add(this.uidLabel);
            this.createAccountTabPage.Controls.Add(this.nameTextBox);
            this.createAccountTabPage.Controls.Add(this.nameLabel);
            this.createAccountTabPage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountTabPage.Location = new System.Drawing.Point(4, 22);
            this.createAccountTabPage.Name = "createAccountTabPage";
            this.createAccountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createAccountTabPage.Size = new System.Drawing.Size(739, 368);
            this.createAccountTabPage.TabIndex = 0;
            this.createAccountTabPage.Text = "Create account";
            this.createAccountTabPage.UseVisualStyleBackColor = true;
            // 
            // accountStatuslabel
            // 
            this.accountStatuslabel.AutoSize = true;
            this.accountStatuslabel.Location = new System.Drawing.Point(49, 14);
            this.accountStatuslabel.Name = "accountStatuslabel";
            this.accountStatuslabel.Size = new System.Drawing.Size(0, 17);
            this.accountStatuslabel.TabIndex = 7;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(488, 298);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 28);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // currentAddressTextBox
            // 
            this.currentAddressTextBox.Location = new System.Drawing.Point(158, 198);
            this.currentAddressTextBox.Multiline = true;
            this.currentAddressTextBox.Name = "currentAddressTextBox";
            this.currentAddressTextBox.Size = new System.Drawing.Size(184, 67);
            this.currentAddressTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(52, 198);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(97, 17);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Current address";
            // 
            // uidTextBox
            // 
            this.uidTextBox.Location = new System.Drawing.Point(158, 93);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(184, 24);
            this.uidTextBox.TabIndex = 3;
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Location = new System.Drawing.Point(49, 96);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(103, 17);
            this.uidLabel.TabIndex = 2;
            this.uidLabel.Text = "Unique Identifier";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(158, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(184, 24);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(49, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // depositMoneyTabPage
            // 
            this.depositMoneyTabPage.Controls.Add(this.transactionTypeComboBox);
            this.depositMoneyTabPage.Controls.Add(this.label1);
            this.depositMoneyTabPage.Controls.Add(this.depositMoneyStatusLabel);
            this.depositMoneyTabPage.Controls.Add(this.accountListComboBox);
            this.depositMoneyTabPage.Controls.Add(this.accountLabel);
            this.depositMoneyTabPage.Controls.Add(this.depositOrWithdrawButton);
            this.depositMoneyTabPage.Controls.Add(this.depositAmountLabel);
            this.depositMoneyTabPage.Controls.Add(this.amountTextBox);
            this.depositMoneyTabPage.Font = new System.Drawing.Font("Calibri", 10F);
            this.depositMoneyTabPage.Location = new System.Drawing.Point(4, 22);
            this.depositMoneyTabPage.Name = "depositMoneyTabPage";
            this.depositMoneyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.depositMoneyTabPage.Size = new System.Drawing.Size(739, 368);
            this.depositMoneyTabPage.TabIndex = 1;
            this.depositMoneyTabPage.Text = " Deposit and withdraw money";
            this.depositMoneyTabPage.UseVisualStyleBackColor = true;
            // 
            // depositMoneyStatusLabel
            // 
            this.depositMoneyStatusLabel.AutoSize = true;
            this.depositMoneyStatusLabel.Location = new System.Drawing.Point(46, 217);
            this.depositMoneyStatusLabel.Name = "depositMoneyStatusLabel";
            this.depositMoneyStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.depositMoneyStatusLabel.TabIndex = 5;
            // 
            // accountListComboBox
            // 
            this.accountListComboBox.FormattingEnabled = true;
            this.accountListComboBox.Location = new System.Drawing.Point(149, 46);
            this.accountListComboBox.Name = "accountListComboBox";
            this.accountListComboBox.Size = new System.Drawing.Size(121, 23);
            this.accountListComboBox.TabIndex = 4;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(43, 49);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(54, 17);
            this.accountLabel.TabIndex = 3;
            this.accountLabel.Text = "Account";
            // 
            // depositOrWithdrawButton
            // 
            this.depositOrWithdrawButton.Location = new System.Drawing.Point(195, 182);
            this.depositOrWithdrawButton.Name = "depositOrWithdrawButton";
            this.depositOrWithdrawButton.Size = new System.Drawing.Size(75, 28);
            this.depositOrWithdrawButton.TabIndex = 2;
            this.depositOrWithdrawButton.Text = "Submit";
            this.depositOrWithdrawButton.UseVisualStyleBackColor = true;
            this.depositOrWithdrawButton.Click += new System.EventHandler(this.depositOrWithdrawButton_Click);
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Location = new System.Drawing.Point(40, 130);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(53, 17);
            this.depositAmountLabel.TabIndex = 1;
            this.depositAmountLabel.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(149, 127);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(121, 24);
            this.amountTextBox.TabIndex = 0;
            // 
            // ageLable
            // 
            this.ageLable.AutoSize = true;
            this.ageLable.Location = new System.Drawing.Point(52, 140);
            this.ageLable.Name = "ageLable";
            this.ageLable.Size = new System.Drawing.Size(30, 17);
            this.ageLable.TabIndex = 8;
            this.ageLable.Text = "Age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(158, 140);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(184, 24);
            this.ageTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Transaction type";
            // 
            // transactionTypeComboBox
            // 
            this.transactionTypeComboBox.FormattingEnabled = true;
            this.transactionTypeComboBox.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.transactionTypeComboBox.Location = new System.Drawing.Point(149, 91);
            this.transactionTypeComboBox.Name = "transactionTypeComboBox";
            this.transactionTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.transactionTypeComboBox.TabIndex = 7;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(AccountBuddy.App.Program);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homePageTabControl);
            this.Name = "MainForm";
            this.Text = "PeopleSoft bank";
            this.homePageTabControl.ResumeLayout(false);
            this.createAccountTabPage.ResumeLayout(false);
            this.createAccountTabPage.PerformLayout();
            this.depositMoneyTabPage.ResumeLayout(false);
            this.depositMoneyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl homePageTabControl;
        private System.Windows.Forms.TabPage createAccountTabPage;
        private System.Windows.Forms.TabPage depositMoneyTabPage;
        private System.Windows.Forms.TextBox uidTextBox;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox currentAddressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button depositOrWithdrawButton;
        private System.Windows.Forms.ComboBox accountListComboBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Label accountStatuslabel;
        private System.Windows.Forms.Label depositMoneyStatusLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLable;
        private System.Windows.Forms.ComboBox transactionTypeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

