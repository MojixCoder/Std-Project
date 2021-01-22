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
    public partial class Form2 : Form
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
        public Form2(string id2)
        {
            InitializeComponent();
            id = id2;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "LOG OUT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void Btn_std_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3(Id());
            f3.Show();
        }

        private void Btn_bank_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4(Id());
            f4.Show();
        }

        private void Btn_deposit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f5 = new Form5(Id());
            f5.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                string st_id = Id();

                student query = (from c in db.students
                                 where c.st_id == st_id
                                 select c).FirstOrDefault<student>();

                lbl_welcome.Text = "Welcome " + query.fname + " " + query.lname + ".";
                lbl_welcome.ForeColor = System.Drawing.Color.White;
                
            }
            Disconnect();
        }

        private void Btn_buy_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f6 = new Form6(Id());
            f6.Show();
        }
    }
}
