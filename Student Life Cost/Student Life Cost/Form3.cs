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
    
    public partial class Form3 : Form
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
            txt_id.Text = txt_fname.Text = txt_lname.Text = txt_pass.Text = "";
        }
        private void SetBtnDel()
        {
            btn_delete.Enabled = (txt_id.Text != "") || (txt_fname.Text != "") || (txt_lname.Text != "");
        }
        private void SetBtnUpdate()
        {
            btn_update.Enabled = (txt_id.Text != "") && (txt_fname.Text != "") && (txt_lname.Text != "");
        }
        private void SetBtnSearch()
        {
            btn_search.Enabled = (txt_id.Text != "") || (txt_fname.Text != "") || (txt_lname.Text != "");
        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        public Form3(string id2)
        {
            InitializeComponent();
            id = id2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_search.Enabled = false;

            Connect();
            using (var db = new StdLifeEntities())
            {
                var result = from x in db.students
                             select new
                             {
                                 id = x.st_id,
                                 fname = x.fname,
                                 lname = x.lname
                             };
                dataGridView1.DataSource = result.ToList();
                Disconnect();
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                if (IsNumeric(txt_id.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add this student?", "ADD STUDENT", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var check_exist = (from c in db.students
                                           where c.st_id == txt_id.Text
                                           select c);
                        if (check_exist.FirstOrDefault() != null)
                        {
                            MessageBox.Show("A user with this ID already exists!!");
                        }
                        else
                        {
                            student add_st = new student();
                            add_st.st_id = txt_id.Text;
                            add_st.fname = txt_fname.Text;
                            add_st.lname = txt_lname.Text;
                            add_st.password = txt_pass.Text;
                            add_st.role = "st";
                            db.students.Add(add_st);
                            db.SaveChanges();
                            Disconnect();
                            ClearTextBoxes();
                        }

                    }
                    var query = from x in db.students
                                select new
                                {
                                    id = x.st_id,
                                    fname = x.fname,
                                    lname = x.lname
                                };
                    dataGridView1.DataSource = query.ToList();

                }
                else
                {
                    MessageBox.Show("ID should be All Numeric!!");
                }
                Disconnect();
            }
        }



        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student", "DELETE STUDENT", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var check_exist = (from c in db.students
                                       where (c.st_id == txt_id.Text || txt_id.Text == "")
                                             && (c.fname == txt_fname.Text || txt_fname.Text == "")
                                             && (c.lname == txt_lname.Text || txt_lname.Text == "")
                                       select c);
                    if (check_exist.FirstOrDefault() != null)
                    {
                        var del_st = (from c in db.students
                                               where (c.st_id == txt_id.Text || txt_id.Text == "")
                                                     && (c.fname == txt_fname.Text || txt_fname.Text == "")
                                                     && (c.lname == txt_lname.Text || txt_lname.Text == "")
                                               select c);
                        foreach(student a in del_st.ToList())
                        {
                            db.students.Remove(a);
                        }
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("No User with this information");
                    }

                    Disconnect();
                    ClearTextBoxes();
                }
                var query = from c in db.students select new
                                                    {
                                                        id = c.st_id,
                                                        fname = c.fname,
                                                        lname = c.lname
                                                    };
                dataGridView1.DataSource = query.ToList();
            }
            Disconnect();

        }

        private void Txt_pass_TextChanged_1(object sender, EventArgs e)
        {
            if(txt_pass.Text == "")
            {
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                btn_search.Enabled = true;
            }
            else
            {
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                btn_search.Enabled = false;
            }
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
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                var search = (from c in db.students where (c.st_id == txt_id.Text || txt_id.Text == "")
                                       && (c.fname == txt_fname.Text || txt_fname.Text == "")
                                       && (c.lname == txt_lname.Text || txt_lname.Text == "")
                                       select new
                                       {
                                           id = c.st_id,
                                           fname = c.fname,
                                           lname = c.lname
                                       }).ToList();

                dataGridView1.DataSource = search;
            }
            Disconnect();

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

        private void Btn_update_Click(object sender, EventArgs e)
        {

            Connect();
            using (var db = new StdLifeEntities())
            {
                
                DialogResult result = MessageBox.Show("Are you sure you want to update the information of this contact?", "UPDATE STUDENT", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var check_exist = (from c in db.students
                                           where c.st_id == txt_id.Text
                                           select c);
                        if (check_exist.FirstOrDefault() != null)
                        {
                            student upd_st = (from c in db.students where c.st_id == txt_id.Text select c).FirstOrDefault<student>();
                            upd_st.fname = txt_fname.Text;
                            upd_st.lname = txt_lname.Text;
                            db.SaveChanges();
                            Disconnect();
                            ClearTextBoxes();
                    }
                        else
                        {
                            MessageBox.Show("No user with this ID!!");
                        }
                    }
                    var query = from c in db.students select new
                                                             {
                                                                  id = c.st_id,
                                                                  fname = c.fname,
                                                                  lname = c.lname
                                                              };
                    dataGridView1.DataSource = query.ToList();
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txt_id.Text = dataGridView1["id", i].Value.ToString();
            txt_fname.Text = dataGridView1["fname", i].Value.ToString();
            txt_lname.Text = dataGridView1["lname", i].Value.ToString();
        }

        private void Txt_lname_TextChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl as TextBox) != null)
                {
                    if((ctrl as TextBox).Text == "")
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


            SetBtnDel();
            SetBtnUpdate();
            SetBtnSearch();


        }

        private void Txt_fname_TextChanged(object sender, EventArgs e)
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


            SetBtnDel();
            SetBtnUpdate();
            SetBtnSearch();

        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
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

            SetBtnDel();
            SetBtnUpdate();
            SetBtnSearch();

        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Connect();
            using (var db = new StdLifeEntities())
            {
                var search = (from c in db.students
                              select new
                              {
                                  id = c.st_id,
                                  fname = c.fname,
                                  lname = c.lname
                              }).ToList();

                dataGridView1.DataSource = search;
            }
            Disconnect();
        }
    }
}
