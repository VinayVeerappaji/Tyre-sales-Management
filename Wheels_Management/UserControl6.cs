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
    public partial class UserControl6 : UserControl
    {
        private static UserControl6 uc1;
        public static UserControl6 Instance
        {
            get
            {
                if (uc1 == null)
                {
                    uc1 = new UserControl6();
                }
                return uc1;
            }
        }
        public UserControl6()
        {
            InitializeComponent();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = mil.Text;
            l.ifcon = "m";
            l.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = fue.Text;
            l.ifcon = "n";
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = form.Text;
            l.ifcon = "o";
            l.ShowDialog();
        }
    }
}
