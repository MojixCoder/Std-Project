﻿namespace Student_Life_Cost
{
    partial class Form6
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_acc = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_com = new System.Windows.Forms.TextBox();
            this.lbl_com = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(26, 343);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(247, 36);
            this.checkBox1.TabIndex = 54;
            this.checkBox1.Text = "Search by Date";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Student ID(Search) :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(297, 280);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(316, 39);
            this.comboBox2.TabIndex = 52;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(20, 215);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(90, 32);
            this.lbl_date.TabIndex = 51;
            this.lbl_date.Text = "Date :";
            // 
            // lbl_acc
            // 
            this.lbl_acc.AutoSize = true;
            this.lbl_acc.ForeColor = System.Drawing.Color.White;
            this.lbl_acc.Location = new System.Drawing.Point(19, 155);
            this.lbl_acc.Name = "lbl_acc";
            this.lbl_acc.Size = new System.Drawing.Size(240, 32);
            this.lbl_acc.TabIndex = 50;
            this.lbl_acc.Text = "Account Number :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 39);
            this.comboBox1.TabIndex = 49;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(130, 94);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(211, 38);
            this.txt_value.TabIndex = 48;
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.ForeColor = System.Drawing.Color.White;
            this.lbl_value.Location = new System.Drawing.Point(20, 97);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(104, 32);
            this.lbl_value.TabIndex = 47;
            this.lbl_value.Text = "Value :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 38);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Location = new System.Drawing.Point(1000, 437);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(218, 49);
            this.btn_back.TabIndex = 45;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(1224, 437);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(218, 49);
            this.btn_exit.TabIndex = 44;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_search
            // 
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_search.Location = new System.Drawing.Point(1149, 149);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(293, 69);
            this.btn_search.TabIndex = 43;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_buy.Location = new System.Drawing.Point(1149, 61);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(293, 71);
            this.btn_buy.TabIndex = 42;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.Btn_buy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 519);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1891, 410);
            this.dataGridView1.TabIndex = 41;
            // 
            // txt_com
            // 
            this.txt_com.Location = new System.Drawing.Point(195, 39);
            this.txt_com.Name = "txt_com";
            this.txt_com.Size = new System.Drawing.Size(211, 38);
            this.txt_com.TabIndex = 55;
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.ForeColor = System.Drawing.Color.White;
            this.lbl_com.Location = new System.Drawing.Point(16, 45);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(173, 32);
            this.lbl_com.TabIndex = 56;
            this.lbl_com.Text = "Commodity :";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(1149, 237);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(293, 69);
            this.btn_refresh.TabIndex = 57;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1953, 964);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_com);
            this.Controls.Add(this.txt_com);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_acc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Std Life Cost";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_com;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.Button btn_refresh;
    }
}