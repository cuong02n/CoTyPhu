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
        public static userForm instance;
        public TextBox tbName;
        public TextBox tbId;
        public userForm()
        {
            InitializeComponent();
            instance = this;
            tbName = tbUserName;
            tbId = tbRoomId;
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
            playForm.instance.name.Text = tbName.Text;
            playForm.instance.id.Text = tbId.Text;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            waitingForm waiting = new waitingForm();
            waiting.Show();
            waitingForm.instance.name.Text = tbUserName.Text;
            waitingForm.instance.id.Text = tbRoomId.Text;
            playForm.instance.name.Text = tbName.Text;
            playForm.instance.id.Text = tbId.Text;
        }
    }
}
