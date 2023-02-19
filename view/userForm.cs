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
            main.name = tbName.Text;
            main.room = Int32.Parse(tbRoomId.Text);
           
            this.Hide();
            mainForm._playForm = new playForm();
            mainForm._playForm.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            main.name = tbName.Text;
            main.room = Int32.Parse(tbRoomId.Text);
            this.Hide();
            mainForm.waiting = new waitingForm();
            mainForm.waiting.Show();
        }
    }
}
