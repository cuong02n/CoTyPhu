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
        public mainForm()
        {
            InitializeComponent();
<<<<<<< HEAD
            CheckForIllegalCrossThreadCalls = false;
=======
            
>>>>>>> 037e837b07348314d05275de8f190e443ae9eeac
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
            control_view.showUserForm(main.room, main.name);
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
