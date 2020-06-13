using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheels_Management
{
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
          

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            if (!ContentPanel.Controls.Contains(UserControl1.Instance))
            {
                ContentPanel.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
            {
                UserControl1.Instance.BringToFront();
            }
        

    }
        
        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            if (!ContentPanel.Controls.Contains(UserControl2.Instance))
            {
                ContentPanel.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();
            }
            else
            {
                UserControl2.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            if (!ContentPanel.Controls.Contains(UserControl3.Instance))
            {
                ContentPanel.Controls.Add(UserControl3.Instance);
                UserControl3.Instance.Dock = DockStyle.Fill;
                UserControl3.Instance.BringToFront();
            }
            else
            {
                UserControl3.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            if (!ContentPanel.Controls.Contains(UserControl4.Instance))
            {
                ContentPanel.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();
            }
            else
            {
                UserControl4.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
            if (!ContentPanel.Controls.Contains(UserControl5.Instance))
            {
                ContentPanel.Controls.Add(UserControl5.Instance);
                UserControl5.Instance.Dock = DockStyle.Fill;
                UserControl5.Instance.BringToFront();
            }
            else
            {
                UserControl5.Instance.BringToFront();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button6.Height;
            sidepanel.Top = button6.Top;
            if (!ContentPanel.Controls.Contains(UserControl6.Instance))
            {
                ContentPanel.Controls.Add(UserControl6.Instance);
                UserControl6.Instance.Dock = DockStyle.Fill;
                UserControl6.Instance.BringToFront();
            }
            else
            {
                UserControl6.Instance.BringToFront();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            sidepanel.Height = button7.Height;
            sidepanel.Top = button7.Top;
            if (!ContentPanel.Controls.Contains(UserControl7.Instance))
            {
                ContentPanel.Controls.Add(UserControl7.Instance);
                UserControl7.Instance.Dock = DockStyle.Fill;
                UserControl7.Instance.BringToFront();
            }
            else
            {
                UserControl7.Instance.BringToFront();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ob = new LoginPage();
            ob.Show();
        }
    }
}
