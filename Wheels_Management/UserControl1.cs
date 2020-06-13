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
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 uc1;
        public static UserControl1 Instance
        {
            get
            {
                if (uc1 == null)
                {
                    uc1 = new UserControl1();
                }
                return uc1;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
