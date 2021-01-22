namespace Student_Life_Cost
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 499);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(916, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(182, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(286, 38);
            this.txt_id.TabIndex = 1;
            this.txt_id.TextChanged += new System.EventHandler(this.Txt_id_TextChanged);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(182, 144);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(286, 38);
            this.txt_lname.TabIndex = 3;
            this.txt_lname.TextChanged += new System.EventHandler(this.Txt_lname_TextChanged);
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(182, 90);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(286, 38);
            this.txt_fname.TabIndex = 2;
            this.txt_fname.TextChanged += new System.EventHandler(this.Txt_fname_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(9, 41);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(155, 32);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "Sudent ID :";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.ForeColor = System.Drawing.Color.White;
            this.lbl_fname.Location = new System.Drawing.Point(9, 96);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(167, 32);
            this.lbl_fname.TabIndex = 5;
            this.lbl_fname.Text = "First Name :";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.ForeColor = System.Drawing.Color.White;
            this.lbl_lname.Location = new System.Drawing.Point(10, 150);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(166, 32);
            this.lbl_lname.TabIndex = 6;
            this.lbl_lname.Text = "Last Name :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(688, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(218, 49);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(180, 203);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(286, 38);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.TextChanged += new System.EventHandler(this.Txt_pass_TextChanged_1);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_pass.Location = new System.Drawing.Point(8, 206);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(154, 32);
            this.lbl_pass.TabIndex = 9;
            this.lbl_pass.Text = "Password :";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(688, 96);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(218, 49);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(688, 290);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(218, 49);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(688, 433);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(218, 49);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(464, 433);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(218, 49);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(688, 160);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(218, 49);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(688, 225);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(218, 49);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(940, 945);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Std Life Cost";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_edit;
    }
}