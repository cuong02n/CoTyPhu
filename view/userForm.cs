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
            playButton.Enabled = false;
            createButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void playButton_Click(object sender, EventArgs e)
        {
            main.name = tbUserName.Text;
            main.room = Int32.Parse(tbRoomId.Text);
           
            this.Hide();
            mainForm._playForm = new playForm();
            mainForm._playForm.Show();
            control_view.goToRoom(Int32.Parse(tbRoomId.Text), tbUserName.Text);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            main.name = tbUserName.Text;
            main.room = Int32.Parse(tbRoomId.Text);
            this.Hide();
            mainForm.waiting = new waitingForm();
            mainForm.waiting.Show();
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                playButton.Enabled = false;
                createButton.Enabled = false;
            }

            else
            {
                playButton.Enabled = true;
                createButton.Enabled = true;
            }



        }

        private void tbUserName_DataContextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
