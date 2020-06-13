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
    public partial class UserControl5 : UserControl
    {
        private static UserControl5 uc1;
        public static UserControl5 Instance
        {
            get
            {
                if (uc1 == null)
                {
                    uc1 = new UserControl5();
                }
                return uc1;
            }
        }
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = b250.Text;
            l.ifcon = "j";
            l.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = eco.Text;
            l.ifcon = "k";
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = pon.Text;
            l.ifcon = "l";
            l.ShowDialog();
        }
    }
}
