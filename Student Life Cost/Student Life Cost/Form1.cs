using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Life_Cost
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Connect();
            using (var db = new StdLifeEntities())
            {
                student query = (from c in db.students 
                             where c.st_id == txt_user.Text && c.password == txt_pass.Text
                             select c).FirstOrDefault<student>();
                if (query != null)
                {
                    string id = query.st_id;
                    this.Hide();
                    Form2 f2 = new Form2(id);
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!!!! Try Again please.");
                }
            }
            Disconnect();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
