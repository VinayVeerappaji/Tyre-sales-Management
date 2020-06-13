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
    public partial class qr : Form
    {
        public string hai;
        public qr()
        {
            InitializeComponent();
        }
        private const int cs_dropshadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= cs_dropshadow;
                return cp;
            }

                
        }

        private void qr_Load(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var mydata = QG.CreateQrCode(hai, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(mydata);
            pictureBox1.Image = code.GetGraphic(50);
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win\source\repos\versions\1\Wheels_Management\Wheels_Management\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private String lastTum()
        {
            //get data from the database
            con.Open();
            String syntax = ("SELECT max(tnum) from Transactions");
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            {
                string tnum = lastTum();
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"images/" + tnum + ".bmp");
                this.Close();
            }
        }
    }
}
