using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Life_Cost
{
    public partial class Form4 : Form
    {
        private string id;
        public string Id()
        {
            return id;
        }
        private SqlConnection conn;
        public void Connect()
        {
            conn = new SqlConnection("Server=.;Database=StdLife;Trusted_Connection=True;");
            conn.Open();
        }
        public void Disconnect()
        {
            conn.Close();
        }
        private void ClearTextBoxes()
        {
            txt_acc.Text = txt_balance.Text = "";
        }
        private void SetBtnDel()
        {
            btn_delete.Enabled = (txt_acc.Text != "") || (txt_balance.Text != "");
        }
        private void SetBtnSearch()
        {
            btn_search.Enabled = (txt_acc.Text != "") || (txt_balance.Text != "");
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        public Form4(string id2)
        {
            InitializeComponent();
            id = id2;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2(Id());
            f2.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_search.Enabled = false;
            btn_delete.Enabled = false;

            Connect();
            using (var db = new StdLifeEntities())
            {                
                var result = from x in db.BankAccs
                             select new {
                                 acc_number = x.accNumber,
                                 balance = x.balance
                             };
                dataGridView1.DataSource = result.ToList();
                Disconnect();
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
         

            Connect();
            using (var db = new StdLifeEntities())
            {
                decimal balance;
                int count = 0;
                if(txt_balance.Text != "")
                {
                    bool isDecimal = Decimal.TryParse(txt_balance.Text, out balance);
                    if (!isDecimal)
                        count++;
                }
                else
                {
                    balance = 0;
                }
                if (count == 0)
                {
                    var search = (from c in db.BankAccs
                                  where (c.accNumber == txt_acc.Text || txt_acc.Text == "")
                                        && (c.balance == balance || txt_balance.Text == "")
                                  select new
                                  {
                                      acc_number = c.accNumber,
                                      balance = c.balance
                                  }).ToList();

                    dataGridView1.DataSource = search;
                }
                else
                {
                    MessageBox.Show("Balance should be Decimal!!!");
                }
               
            }
            Disconnect();
        }

        private void Txt_acc_TextChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl as TextBox) != null)
                {
                    if ((ctrl as TextBox).Text == "")
                    {
                        btn_add.Enabled = false;
                        break;
                    }
                    else
                    {
                        btn_add.Enabled = true;
                    }
                }
            }

            SetBtnSearch();
            SetBtnDel();
        }

        private void Txt_balance_TextChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl as TextBox) != null)
                {
                    if ((ctrl as TextBox).Text == "")
                    {
                        btn_add.Enabled = false;
                        break;
                    }
                    else
                    {
                        btn_add.Enabled = true;
                    }
                }
            }

            SetBtnSearch();
            SetBtnDel();
        }

        private void Btn_choose_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txt_acc.Text = dataGridView1["acc_number", i].Value.ToString();
            txt_balance.Text = dataGridView1["balance", i].Value.ToString();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Bank Account", "DELETE BANK ACCOUNT", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    decimal balance;
                    int count = 0;
                    if (txt_balance.Text != "")
                    {
                        bool isDecimal = Decimal.TryParse(txt_balance.Text, out balance);
                        if (!isDecimal)
                            count++;
                    }
                    else
                    {
                        balance = 0;
                    }
                    if(count == 0)
                    {
                        var check_exist = (from c in db.BankAccs
                                           where (c.accNumber == txt_acc.Text || txt_acc.Text == "")
                                                 && (c.balance == balance || txt_balance.Text == "")
                                           select c);
                        if (check_exist.FirstOrDefault() != null)
                        {
                            var del_acc = (from c in db.BankAccs
                                               where (c.accNumber == txt_acc.Text || txt_acc.Text == "")
                                                     && (c.balance == balance || txt_balance.Text == "")
                                               select c);
                            foreach(BankAcc a in del_acc.ToList())
                            {
                                db.BankAccs.Remove(a);
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("No User with this information");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Balance should be Decimal!!!");
                    }
                    Disconnect();
                    ClearTextBoxes();
                }
                var query = from x in db.BankAccs
                             select new
                             {
                                 acc_number = x.accNumber,
                                 balance = x.balance
                             };
                dataGridView1.DataSource = query.ToList();
            }
            Disconnect();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            decimal balance;
            bool isDecimal = Decimal.TryParse(txt_balance.Text, out balance);
            Connect();
            using (var db = new StdLifeEntities())
            {
                if (IsNumeric(txt_acc.Text) && isDecimal)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add this Bank Account?", "ADD BANK ACCOUNT", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var check_exist = (from c in db.BankAccs
                                           where c.accNumber == txt_acc.Text
                                           select c);
                        if (check_exist.FirstOrDefault() != null)
                        {
                            MessageBox.Show("A user with this ID already exists!!");
                        }
                        else
                        {
                            BankAcc add_acc = new BankAcc();
                            add_acc.accNumber = txt_acc.Text;
                            add_acc.balance = balance;
                            db.BankAccs.Add(add_acc);
                            db.SaveChanges();
                            Disconnect();
                            ClearTextBoxes();
                        }

                    }
                    var query = from x in db.BankAccs
                                select new
                                {
                                    acc_number = x.accNumber,
                                    balance = x.balance
                                };
                    dataGridView1.DataSource = query.ToList();

                }
                else
                {
                    MessageBox.Show("Account Number should be All Numeric and Balance Should be Decimal!!");
                }
                Disconnect();
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Connect();
            using (var db = new StdLifeEntities())
            {
                var search = (from c in db.BankAccs
                              select new
                              {
                                  acc_number = c.accNumber,
                                  balance = c.balance
                              }).ToList();

                dataGridView1.DataSource = search;
            }
            Disconnect();
        }
    }
}
