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
    public partial class waitingForm : Form
    {
        public static waitingForm instance;
        public Label id;
        public Label name;
        public waitingForm()
        {
            InitializeComponent();
           instance = this;
            id = idView;
            name = nameView;
            if (Int32.Parse(lbNumberPlayer.Text) < 2)
            {
                playButton.Enabled = false;
            }
            else if(Int32.Parse(lbNumberPlayer.Text) <= 4)
            {
                playButton.Enabled = true;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            playForm play = new playForm();
            play.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.Show();
        }
    }
}
