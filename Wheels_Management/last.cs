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
    public partial class last : Form
    {
        public last()
        {
            InitializeComponent();

        }
        public new string ProductName;
        public  string ifcon;
   
        private void last_Load(object sender, EventArgs e)
        {
            prdname.Text = ProductName;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win\source\repos\versions\1\Wheels_Management\Wheels_Management\Database.mdf;Integrated Security=True");

        




        private void cnfbtn_Click(object sender, EventArgs e)
        {
            if(ifcon=="a")
            {
                if(comboBox1.Text=="1")
                {
                    label2.Text = "2873";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "5746";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "8619";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "11492";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "14365";
                    label2.Visible = true;
                }

            }
            if(ifcon=="b")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "6168";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "12336";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "18504";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "24672";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "30840";
                    label2.Visible = true;
                }
            }
            if(ifcon=="c")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "5330";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "10660";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "15990";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "21320";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "26650";
                    label2.Visible = true;
                }
            }
            if(ifcon=="d")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "4995";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "9990";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "14985";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "19980";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "24975";
                    label2.Visible = true;
                }
            }
            if(ifcon=="e")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "8940";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "17880";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "26820";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "35760";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "44700";
                    label2.Visible = true;
                }
            }
            if(ifcon=="f")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "20085";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "40170";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "60255";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "80340";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "100425";
                    label2.Visible = true;
                }
            }
            if(ifcon=="g")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "10487";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "20974";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "31461";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "41948";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "52435";
                    label2.Visible = true;
                }
            }
            if(ifcon=="h")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "3794";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "7588";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "11382";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "15176";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "18970";
                    label2.Visible = true;
                }




            }
            if(ifcon=="i")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "4000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "8000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "12000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "16000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "20000";
                    label2.Visible = true;
                }
            }
            if(ifcon=="j")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "5045";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "10090";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "15135";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "20180";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "25225";
                    label2.Visible = true;
                }
            }
            if(ifcon=="k")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "3300";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "6600";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "9900";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "13200";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "16500";
                    label2.Visible = true;
                }
            }
            if (ifcon == "l")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "7064";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "14128";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "21192";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "28256";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "35320";
                    label2.Visible = true;
                }
            }
            if(ifcon=="m")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "3099";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "6198";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "9297";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "12396";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "15495";
                    label2.Visible = true;
                }
            }
            if(ifcon=="n")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "3000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "6000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "9000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "12000";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "15000";
                    label2.Visible = true;
                }
            }
            if(ifcon=="o")
            {
                if (comboBox1.Text == "1")
                {
                    label2.Text = "5774";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "2")
                {
                    label2.Text = "11548";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "3")
                {
                    label2.Text = "17332";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "4")
                {
                    label2.Text = "23096";
                    label2.Visible = true;
                }
                if (comboBox1.Text == "5")
                {
                    label2.Text = "28870";
                    label2.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            if (ifcon=="a")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);

                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 1);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if(comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    
                }
                catch(Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n"+ exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "b")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 2);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "c")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 1);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "d")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 4);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "e")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 5);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "f")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 6);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "g")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 7);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "h")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 8);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "i")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 9);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "j")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 10);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "k")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 11);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "l")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 12);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "m")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 13);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "n")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 14);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }
            if (ifcon == "o")
            {
                SqlCommand cmd = new SqlCommand("transact_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", txtname.Text);
                cmd.Parameters.AddWithValue("@cmob", txtph.Text);
                cmd.Parameters.AddWithValue("@tid", 15);
                cmd.Parameters.AddWithValue("@quantity", comboBox1.Text);
                cmd.Parameters.AddWithValue("@total", label2.Text);
                if (comboBox2.Text.Equals("Cash"))
                {
                    cmd.Parameters.AddWithValue("@pid", 1);
                }
                if (comboBox2.Text.Equals("Credit/Debit Card"))
                {
                    cmd.Parameters.AddWithValue("@pid", 2);
                }
                if (comboBox2.Text.Equals("Online Payment"))
                {
                    cmd.Parameters.AddWithValue("@pid", 3);
                }
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("INVALID SQL OPERATION /n" + exp);
                }
                con.Close();
                MessageBox.Show("Thank You!!!");
                this.Hide();


            }

            qr q = new qr();
            q.hai = prdname.Text +" "+ txtname.Text + " " + txtph.Text + "    " + comboBox1.Text + "    " + label2.Text + "    " +
                " " + comboBox2.Text;
            q.ShowDialog();
        }
    }
}
