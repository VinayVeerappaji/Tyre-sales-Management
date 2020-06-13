using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheels_Management
{
    public partial class UserControl4 : UserControl
    {
        private static UserControl4 uc1;
        public static UserControl4 Instance
        {
            get
            {
                if (uc1 == null)
                {
                    uc1 = new UserControl4();
                }
                return uc1;
            }
        }
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = wra.Text;
            l.ifcon = "g";

            l.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = dur.Text;
            l.ifcon = "h";
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = tri.Text;
            l.ifcon = "i";
            l.ShowDialog();
        }
    }
}
