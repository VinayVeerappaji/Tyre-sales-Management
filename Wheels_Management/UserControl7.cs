using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wheels_Management
{
    public partial class UserControl7 : UserControl
    {
        private static UserControl7 uc1;
        public static UserControl7 Instance
        {
            get
            {
                if (uc1 == null)
                {
                    uc1 = new UserControl7();
                }
                return uc1;
            }
        }
        public UserControl7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win\source\repos\versions\1\Wheels_Management\Wheels_Management\Database.mdf;Integrated Security=True");


        public void refresh_DataGridView1()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Fetch_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@warranty", comboBox2.Text);
                cmd.Parameters.AddWithValue("@tsize", comboBox3.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("INVALID SQL OPERATION \n" + e);
                }
                con.Close();
                dataGridViewf.DataSource = DS.Tables[0];

            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
            }



        }
        private void UserControl7_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
          if(comboBox1.Text.Equals(null)) 
            {
                MessageBox.Show("Please insert all the options");
            }
            refresh_DataGridView1();
        }
    }
}
