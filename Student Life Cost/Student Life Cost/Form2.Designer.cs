namespace Student_Life_Cost
{
    partial class Form2
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
            this.btn_std = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_bank = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_std
            // 
            this.btn_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_std.Location = new System.Drawing.Point(119, 143);
            this.btn_std.Name = "btn_std";
            this.btn_std.Size = new System.Drawing.Size(313, 86);
            this.btn_std.TabIndex = 0;
            this.btn_std.Text = "Student";
            this.btn_std.UseVisualStyleBackColor = true;
            this.btn_std.Click += new System.EventHandler(this.Btn_std_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.Location = new System.Drawing.Point(455, 143);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(313, 86);
            this.btn_buy.TabIndex = 1;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.Btn_buy_Click);
            // 
            // btn_bank
            // 
            this.btn_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bank.Location = new System.Drawing.Point(119, 248);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(313, 86);
            this.btn_bank.TabIndex = 2;
            this.btn_bank.Text = "Bank Accounts";
            this.btn_bank.UseVisualStyleBackColor = true;
            this.btn_bank.Click += new System.EventHandler(this.Btn_bank_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.Location = new System.Drawing.Point(455, 248);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(313, 86);
            this.btn_deposit.TabIndex = 3;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.Btn_deposit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(661, 535);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(216, 52);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(427, 535);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(216, 52);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(33, 33);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(93, 32);
            this.lbl_welcome.TabIndex = 6;
            this.lbl_welcome.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(907, 608);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.btn_bank);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.btn_std);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Std Life Cost";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_std;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_bank;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_welcome;
    }
}