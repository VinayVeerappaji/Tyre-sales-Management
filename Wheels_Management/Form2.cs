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

namespace Wheels_Management
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win\source\repos\versions\1\Wheels_Management\Wheels_Management\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private String getUserName()
        {
            //get data from the database
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private String getPassword()
        {
            //get data from the database
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }






        private void button2_Click(object sender, EventArgs e)
        {
            String Uname = getUserName(), Upass = "1", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                adminForm1 obj1 = new adminForm1();
                this.Hide();
                obj1.Show();


            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppBody obj = new AppBody();
            this.Hide();
            obj.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
