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
    public partial class mainForm : Form {
        public static userForm user;
        public static playForm _playForm;
        public static waitingForm waiting;
        public static void showPlayForm(int roomId, string name)
        {
            main._playForm = new playForm();
            main._playForm.Show();
        }
        public static void showWaitingForm(int roomId, string name)
        {

            main.waitingForm = new waitingForm();
            main.waitingForm.Show();
        }
        public static void showUserForm(int roomId, string name)
        {
            main.userForm = new userForm();
            main.userForm.Show();
        }
        public static void showMainForm()
        {
            main.mainForm = new mainForm();
            main.mainForm.Show();
        }
        public mainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.showUserForm(main.room, main.name);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
