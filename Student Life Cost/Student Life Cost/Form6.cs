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
    public partial class Form6 : Form
    {
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

        private string id;
        public string Id()
        {
            return id;
        }
        public Form6(string id2)
        {
            InitializeComponent();
            id = id2;
        }

        private void fillCombo()
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                var result = (from x in db.BankAccs
                              select new
                              {
                                  acc_number = x.accNumber
                              });

                foreach (var acc in result.ToArray())
                {
                    comboBox1.Items.Add(acc.acc_number);
                }

                Disconnect();
            }
        }
        private void fillComboSt()
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                var result = (from x in db.students
                              select new
                              {
                                  id = x.st_id
                              });

                foreach (var st in result.ToArray())
                {
                    comboBox2.Items.Add(st.id);
                }

                Disconnect();
            }
        }
        private void ClearTextBoxes()
        {
            txt_value.Text = txt_com.Text = "";
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

        private void Form6_Load(object sender, EventArgs e)
        {
            Connect();
            fillCombo();
            fillComboSt();
            using (var db = new StdLifeEntities())
            {
                var result = from x in db.students
                             join c in db.Buys on x.st_id equals c.st_id
                             join z in db.BankAccs on c.accNumber equals z.accNumber
                             select new
                             {
                                 student_id = c.st_id,
                                 name = x.fname + x.lname,
                                 acc_number = z.accNumber,
                                 Commodity = c.stuff,
                                 value = c.value,
                                 date = c.year + "/" + c.month + "/" + c.day
                             };
                dataGridView1.DataSource = result.ToList();
                Disconnect();
            }
        }

        private void Btn_buy_Click(object sender, EventArgs e)
        {
            if (txt_value.Text != "" && comboBox1.GetItemText(comboBox1.SelectedItem) != "" && txt_com.Text != "")
            {
                Connect();


                using (var db = new StdLifeEntities())
                {
                    string acc = comboBox1.GetItemText(comboBox1.SelectedItem);
                    BankAcc query = (from c in db.BankAccs
                                     where c.accNumber == acc
                                     select c).FirstOrDefault<BankAcc>();
                    if (query != null)
                    {
                        decimal value;
                        bool isDecimal = Decimal.TryParse(txt_value.Text, out value);
                        if (isDecimal)
                        {
                            if(query.balance > value)
                            {
                                DialogResult result = MessageBox.Show("Are you sure you want to Buy?", "BUY", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    Buy add_by = new Buy();
                                    add_by.stuff = txt_com.Text;
                                    add_by.st_id = Id();
                                    add_by.accNumber = acc;
                                    add_by.value = value;
                                    add_by.year = dateTimePicker1.Value.Year.ToString();
                                    add_by.month = dateTimePicker1.Value.Month.ToString();
                                    add_by.day = dateTimePicker1.Value.Day.ToString();
                                    db.Buys.Add(add_by);
                                    db.SaveChanges();
                                    BankAcc upd_acc = (from c in db.BankAccs where c.accNumber == acc select c).FirstOrDefault<BankAcc>();
                                    upd_acc.balance -= value;
                                    db.SaveChanges();
                                    Disconnect();
                                    ClearTextBoxes();
                                }
                                var asd = from x in db.students
                                          join c in db.Buys on x.st_id equals c.st_id
                                          join z in db.BankAccs on c.accNumber equals z.accNumber
                                          select new
                                          {
                                              student_id = c.st_id,
                                              name = x.fname + x.lname,
                                              acc_number = z.accNumber,
                                              Commodity = c.stuff,
                                              value = c.value,
                                              date = c.year + "/" + c.month + "/" + c.day
                                          };
                                dataGridView1.DataSource = asd.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Not enough Balance for this Commodity!!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Value Should be Decimal!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No Bank Account with this Account number exists!!!!");
                    }


                }

                Disconnect();
            }
            else
            {
                MessageBox.Show("Fill Commodity and Value and Date and Account Number!!");
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            bool byDate = checkBox1.Checked;
            Connect();
            using (var db = new StdLifeEntities())
            {
                string year = "", month = "", day = "";
                decimal value = 0;
                bool isDecimal = true;
                string acc = comboBox1.GetItemText(comboBox1.SelectedItem);
                string stid = comboBox2.GetItemText(comboBox2.SelectedItem);
                if (txt_value.Text != "")
                {
                    isDecimal = Decimal.TryParse(txt_value.Text, out value);
                }
                if (isDecimal)
                {
                    if (byDate)
                    {
                        if (dateTimePicker1.Value.Year.ToString() != "")
                        {
                            year = dateTimePicker1.Value.Year.ToString();

                        }
                        if (dateTimePicker1.Value.Month.ToString() != "")
                        {
                            month = dateTimePicker1.Value.Month.ToString();
                        }
                        if (dateTimePicker1.Value.Day.ToString() != "")
                        {
                            day = dateTimePicker1.Value.Day.ToString();
                        }
                    }


                    var search = (from x in db.students
                                  join c in db.Buys on x.st_id equals c.st_id
                                  join z in db.BankAccs on c.accNumber equals z.accNumber
                                  where (c.year == year || year == "")
                                        && (c.month == month || month == "")
                                        && (c.day == day || day == "")
                                        && (c.value == value || txt_value.Text == "")
                                        && (c.accNumber == acc || acc == "")
                                        && (c.st_id == stid || stid == "")
                                        && (c.stuff == txt_com.Text || txt_com.Text == "")
                                  select new
                                  {
                                      student_id = c.st_id,
                                      name = x.fname + " " + x.lname,
                                      acc_number = z.accNumber,
                                      Commodity = c.stuff,
                                      value = c.value,
                                      date = c.year + "/" + c.month + "/" + c.day
                                  }).ToList();
                    dataGridView1.DataSource = search;

                }
                else
                {
                    MessageBox.Show("Value Should be Decimal!!");
                }

                if (!byDate && acc == "" && stid == "" && isDecimal && txt_com.Text == "" && txt_value.Text == "")
                {
                    dataGridView1.DataSource = null;
                }
            }
            Disconnect();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Connect();
            using (var db = new StdLifeEntities())
            {
                var result = from x in db.students
                             join c in db.Buys on x.st_id equals c.st_id
                             join z in db.BankAccs on c.accNumber equals z.accNumber
                             select new
                             {
                                 student_id = c.st_id,
                                 name = x.fname + x.lname,
                                 acc_number = z.accNumber,
                                 Commodity = c.stuff,
                                 value = c.value,
                                 date = c.year + "/" + c.month + "/" + c.day
                             };
                dataGridView1.DataSource = result.ToList();
            }
            Disconnect();
        }
    }
}
