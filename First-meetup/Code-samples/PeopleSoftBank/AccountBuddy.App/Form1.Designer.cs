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
            this.homePageTabControl = new System.Windows.Forms.TabControl();
            this.createAccountTabPage = new System.Windows.Forms.TabPage();
            this.depositMoneyTabPage = new System.Windows.Forms.TabPage();
            this.withdrawMoneytTabPage = new System.Windows.Forms.TabPage();
            this.homePageTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePageTabControl
            // 
            this.homePageTabControl.Controls.Add(this.createAccountTabPage);
            this.homePageTabControl.Controls.Add(this.depositMoneyTabPage);
            this.homePageTabControl.Controls.Add(this.withdrawMoneytTabPage);
            this.homePageTabControl.Location = new System.Drawing.Point(25, 26);
            this.homePageTabControl.Name = "homePageTabControl";
            this.homePageTabControl.SelectedIndex = 0;
            this.homePageTabControl.Size = new System.Drawing.Size(747, 394);
            this.homePageTabControl.TabIndex = 0;
            // 
            // createAccountTabPage
            // 
            this.createAccountTabPage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountTabPage.Location = new System.Drawing.Point(4, 22);
            this.createAccountTabPage.Name = "createAccountTabPage";
            this.createAccountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createAccountTabPage.Size = new System.Drawing.Size(739, 368);
            this.createAccountTabPage.TabIndex = 0;
            this.createAccountTabPage.Text = "Create account";
            this.createAccountTabPage.UseVisualStyleBackColor = true;
            // 
            // depositMoneyTabPage
            // 
            this.depositMoneyTabPage.Location = new System.Drawing.Point(4, 22);
            this.depositMoneyTabPage.Name = "depositMoneyTabPage";
            this.depositMoneyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.depositMoneyTabPage.Size = new System.Drawing.Size(739, 368);
            this.depositMoneyTabPage.TabIndex = 1;
            this.depositMoneyTabPage.Text = " Deposit money";
            this.depositMoneyTabPage.UseVisualStyleBackColor = true;
            // 
            // withdrawMoneytTabPage
            // 
            this.withdrawMoneytTabPage.Location = new System.Drawing.Point(4, 22);
            this.withdrawMoneytTabPage.Name = "withdrawMoneytTabPage";
            this.withdrawMoneytTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.withdrawMoneytTabPage.Size = new System.Drawing.Size(739, 368);
            this.withdrawMoneytTabPage.TabIndex = 2;
            this.withdrawMoneytTabPage.Text = "Withdraw money";
            this.withdrawMoneytTabPage.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl homePageTabControl;
        private System.Windows.Forms.TabPage createAccountTabPage;
        private System.Windows.Forms.TabPage depositMoneyTabPage;
        private System.Windows.Forms.TabPage withdrawMoneytTabPage;
    }
}

