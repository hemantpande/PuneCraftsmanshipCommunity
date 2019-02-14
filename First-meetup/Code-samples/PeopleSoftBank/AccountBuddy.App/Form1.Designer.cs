namespace AccountBuddy.App
{
    partial class Form1
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
            this.dashBoard = new System.Windows.Forms.GroupBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.depositMoneyButton = new System.Windows.Forms.Button();
            this.withdrawMoneyButton = new System.Windows.Forms.Button();
            this.dashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashBoard.Controls.Add(this.withdrawMoneyButton);
            this.dashBoard.Controls.Add(this.depositMoneyButton);
            this.dashBoard.Controls.Add(this.createAccountButton);
            this.dashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard.Location = new System.Drawing.Point(93, 60);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(622, 318);
            this.dashBoard.TabIndex = 0;
            this.dashBoard.TabStop = false;
            this.dashBoard.Text = "Dashboard";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(54, 78);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(149, 40);
            this.createAccountButton.TabIndex = 0;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            // 
            // depositMoneyButton
            // 
            this.depositMoneyButton.Location = new System.Drawing.Point(254, 78);
            this.depositMoneyButton.Name = "depositMoneyButton";
            this.depositMoneyButton.Size = new System.Drawing.Size(127, 40);
            this.depositMoneyButton.TabIndex = 1;
            this.depositMoneyButton.Text = "Deposit";
            this.depositMoneyButton.UseVisualStyleBackColor = true;
            // 
            // withdrawMoneyButton
            // 
            this.withdrawMoneyButton.Location = new System.Drawing.Point(442, 78);
            this.withdrawMoneyButton.Name = "withdrawMoneyButton";
            this.withdrawMoneyButton.Size = new System.Drawing.Size(113, 40);
            this.withdrawMoneyButton.TabIndex = 2;
            this.withdrawMoneyButton.Text = "Withdraw";
            this.withdrawMoneyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashBoard);
            this.Name = "Form1";
            this.Text = "PeopleSoft bank";
            this.dashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dashBoard;
        private System.Windows.Forms.Button withdrawMoneyButton;
        private System.Windows.Forms.Button depositMoneyButton;
        private System.Windows.Forms.Button createAccountButton;
    }
}

