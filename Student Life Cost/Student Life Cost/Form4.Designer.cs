namespace Student_Life_Cost
{
    partial class Form4
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
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_acc = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_acc = new System.Windows.Forms.TextBox();
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.ForeColor = System.Drawing.Color.White;
            this.lbl_balance.Location = new System.Drawing.Point(19, 96);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(134, 32);
            this.lbl_balance.TabIndex = 15;
            this.lbl_balance.Text = "Balance :";
            // 
            // lbl_acc
            // 
            this.lbl_acc.AutoSize = true;
            this.lbl_acc.ForeColor = System.Drawing.Color.White;
            this.lbl_acc.Location = new System.Drawing.Point(19, 41);
            this.lbl_acc.Name = "lbl_acc";
            this.lbl_acc.Size = new System.Drawing.Size(240, 32);
            this.lbl_acc.TabIndex = 14;
            this.lbl_acc.Text = "Account Number :";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(265, 90);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(286, 38);
            this.txt_balance.TabIndex = 11;
            this.txt_balance.TextChanged += new System.EventHandler(this.Txt_balance_TextChanged);
            // 
            // txt_acc
            // 
            this.txt_acc.Location = new System.Drawing.Point(265, 36);
            this.txt_acc.Name = "txt_acc";
            this.txt_acc.Size = new System.Drawing.Size(286, 38);
            this.txt_acc.TabIndex = 10;
            this.txt_acc.TextChanged += new System.EventHandler(this.Txt_acc_TextChanged);
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(688, 165);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(218, 49);
            this.btn_choose.TabIndex = 25;
            this.btn_choose.Text = "Choose";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.Btn_choose_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(464, 437);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(218, 49);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(688, 437);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(218, 49);
            this.btn_exit.TabIndex = 22;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(688, 231);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(218, 49);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(688, 100);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(218, 49);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(688, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(218, 49);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 527);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(916, 410);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(944, 977);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_acc);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_acc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Std Life Cost";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_acc;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}