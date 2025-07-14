using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopForm
{
    public partial class Form1 : Form
    {

        private string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            nameLabel.Text = name;
            nameLabel.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            MessageBox.Show("The name was saved successfully!");
            nameTextBox.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
