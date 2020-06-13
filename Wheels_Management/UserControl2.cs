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
    public partial class UserControl2 : UserControl
    {
        private static UserControl2 uc1;
        public static UserControl2 Instance
        {
            get
            {
                if (uc1 == null)
                {
                    uc1 = new UserControl2();
                }
                return uc1;
            }
}
        public UserControl2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = zvts.Text;
            l.ifcon = "a";
            l.ShowDialog();
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            last l = new last();
            l.ProductName = wan.Text;
            l.ifcon = "b";
            l.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            last l = new last();
            l.ProductName = zgp.Text;
            l.ifcon = "c";
            l.ShowDialog();
        }
    }
}
