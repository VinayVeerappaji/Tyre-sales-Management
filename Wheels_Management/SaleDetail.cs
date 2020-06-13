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
    public partial class SaleDetail : Form
    {
        public SaleDetail()
        {
            InitializeComponent();
        }

        private void SaleDetail_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm1 ob = new adminForm1();
            ob.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win\source\repos\versions\1\Wheels_Management\Wheels_Management\Database.mdf;Integrated Security=True");
       
       
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("saledetail_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show("INVALID SQL OPERATION \n" + e);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
               
            }
            catch(Exception e)
            {
                MessageBox.Show(" " + e);
            }
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm1 ob = new adminForm1();
            ob.Show();


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
