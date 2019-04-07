

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
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.ageLable = new System.Windows.Forms.Label();
            this.accountStatuslabel = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.addrTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.uidtextBox = new System.Windows.Forms.TextBox();
            this.uidLabel = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.trnsTypCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depositMoneyStatusLabel = new System.Windows.Forms.Label();
            this.accListCB = new System.Windows.Forms.ComboBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.depositOrWithdrawButton = new System.Windows.Forms.Button();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.amtTxt = new System.Windows.Forms.TextBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tc1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tc1
            // 
            this.tc1.Controls.Add(this.tabPage1);
            this.tc1.Controls.Add(this.tp2);
            this.tc1.Location = new System.Drawing.Point(33, 32);
            this.tc1.Margin = new System.Windows.Forms.Padding(4);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(996, 485);
            this.tc1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.ageLable);
            this.tabPage1.Controls.Add(this.accountStatuslabel);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.addrTB);
            this.tabPage1.Controls.Add(this.addressLabel);
            this.tabPage1.Controls.Add(this.uidtextBox);
            this.tabPage1.Controls.Add(this.uidLabel);
            this.tabPage1.Controls.Add(this.nametxt);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(988, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(211, 172);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(244, 28);
            this.txtAge.TabIndex = 4;
            // 
            // ageLable
            // 
            this.ageLable.AutoSize = true;
            this.ageLable.Location = new System.Drawing.Point(69, 172);
            this.ageLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLable.Name = "ageLable";
            this.ageLable.Size = new System.Drawing.Size(36, 21);
            this.ageLable.TabIndex = 8;
            this.ageLable.Text = "Age";
            // 
            // accountStatuslabel
            // 
            this.accountStatuslabel.AutoSize = true;
            this.accountStatuslabel.Location = new System.Drawing.Point(65, 17);
            this.accountStatuslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountStatuslabel.Name = "accountStatuslabel";
            this.accountStatuslabel.Size = new System.Drawing.Size(0, 21);
            this.accountStatuslabel.TabIndex = 7;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(651, 367);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 34);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Create";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // addrTB
            // 
            this.addrTB.Location = new System.Drawing.Point(211, 244);
            this.addrTB.Margin = new System.Windows.Forms.Padding(4);
            this.addrTB.Multiline = true;
            this.addrTB.Name = "addrTB";
            this.addrTB.Size = new System.Drawing.Size(244, 82);
            this.addrTB.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(69, 244);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(121, 21);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Current address";
            // 
            // uidtextBox
            // 
            this.uidtextBox.Location = new System.Drawing.Point(211, 114);
            this.uidtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uidtextBox.Name = "uidtextBox";
            this.uidtextBox.Size = new System.Drawing.Size(244, 28);
            this.uidtextBox.TabIndex = 3;
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Location = new System.Drawing.Point(65, 118);
            this.uidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(126, 21);
            this.uidLabel.TabIndex = 2;
            this.uidLabel.Text = "Unique Identifier";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(211, 65);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(244, 28);
            this.nametxt.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(65, 69);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.trnsTypCombo);
            this.tp2.Controls.Add(this.label1);
            this.tp2.Controls.Add(this.depositMoneyStatusLabel);
            this.tp2.Controls.Add(this.accListCB);
            this.tp2.Controls.Add(this.accountLabel);
            this.tp2.Controls.Add(this.depositOrWithdrawButton);
            this.tp2.Controls.Add(this.depositAmountLabel);
            this.tp2.Controls.Add(this.amtTxt);
            this.tp2.Font = new System.Drawing.Font("Calibri", 10F);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Margin = new System.Windows.Forms.Padding(4);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(4);
            this.tp2.Size = new System.Drawing.Size(988, 456);
            this.tp2.TabIndex = 1;
            this.tp2.Text = " Deposit and withdraw money";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // trnsTypCombo
            // 
            this.trnsTypCombo.FormattingEnabled = true;
            this.trnsTypCombo.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.trnsTypCombo.Location = new System.Drawing.Point(199, 112);
            this.trnsTypCombo.Margin = new System.Windows.Forms.Padding(4);
            this.trnsTypCombo.Name = "trnsTypCombo";
            this.trnsTypCombo.Size = new System.Drawing.Size(160, 29);
            this.trnsTypCombo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Transaction type";
            // 
            // depositMoneyStatusLabel
            // 
            this.depositMoneyStatusLabel.AutoSize = true;
            this.depositMoneyStatusLabel.Location = new System.Drawing.Point(61, 267);
            this.depositMoneyStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositMoneyStatusLabel.Name = "depositMoneyStatusLabel";
            this.depositMoneyStatusLabel.Size = new System.Drawing.Size(0, 21);
            this.depositMoneyStatusLabel.TabIndex = 5;
            // 
            // accListCB
            // 
            this.accListCB.FormattingEnabled = true;
            this.accListCB.Location = new System.Drawing.Point(199, 57);
            this.accListCB.Margin = new System.Windows.Forms.Padding(4);
            this.accListCB.Name = "accListCB";
            this.accListCB.Size = new System.Drawing.Size(160, 29);
            this.accListCB.TabIndex = 4;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(57, 60);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(67, 21);
            this.accountLabel.TabIndex = 3;
            this.accountLabel.Text = "Account";
            // 
            // depositOrWithdrawButton
            // 
            this.depositOrWithdrawButton.Location = new System.Drawing.Point(260, 224);
            this.depositOrWithdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.depositOrWithdrawButton.Name = "depositOrWithdrawButton";
            this.depositOrWithdrawButton.Size = new System.Drawing.Size(100, 34);
            this.depositOrWithdrawButton.TabIndex = 2;
            this.depositOrWithdrawButton.Text = "Submit";
            this.depositOrWithdrawButton.UseVisualStyleBackColor = true;
            this.depositOrWithdrawButton.Click += new System.EventHandler(this.depositOrWithdrawButton_Click);
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Location = new System.Drawing.Point(53, 160);
            this.depositAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(67, 21);
            this.depositAmountLabel.TabIndex = 1;
            this.depositAmountLabel.Text = "Amount";
            // 
            // amtTxt
            // 
            this.amtTxt.Location = new System.Drawing.Point(199, 156);
            this.amtTxt.Margin = new System.Windows.Forms.Padding(4);
            this.amtTxt.Name = "amtTxt";
            this.amtTxt.Size = new System.Drawing.Size(160, 28);
            this.amtTxt.TabIndex = 0;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(AccountBuddy.App.Program);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tc1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "PeopleSoft bank";
            this.tc1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TextBox uidtextBox;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox addrTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.TextBox amtTxt;
        private System.Windows.Forms.Button depositOrWithdrawButton;
        private System.Windows.Forms.ComboBox accListCB;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Label accountStatuslabel;
        private System.Windows.Forms.Label depositMoneyStatusLabel;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label ageLable;
        private System.Windows.Forms.ComboBox trnsTypCombo;
        private System.Windows.Forms.Label label1;
    }
}

