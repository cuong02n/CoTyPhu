using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTyPhu.view
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm._playForm = new playForm();
            mainForm._playForm.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.waitingForm = new waitingForm();
            mainForm.waitingForm.Show();
        }
    }
}
