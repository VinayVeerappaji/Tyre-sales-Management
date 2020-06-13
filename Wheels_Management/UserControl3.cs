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
    public partial class UserControl3 : UserControl
    {
        private static UserControl3 uc1;
        public static UserControl3 Instance
        {
            get
            {
                if (uc1 == null)
                {
                    uc1 = new UserControl3();
                }
                return uc1;
            }
        }
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = xm2.Text;
            l.ifcon = "d";
            l.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = ltx.Text;
            l.ifcon = "e";
            l.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = lat.Text;

            l.ifcon = "f";
            
            l.ShowDialog();
        }
    }
}
