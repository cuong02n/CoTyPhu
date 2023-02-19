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
        public void hide() { }
        public void create(int x,string name)
        {

        }
        public waitingForm()
        {
            InitializeComponent();
            nameView.Text = main.name ;
            idView.Text = main.room.ToString() ;
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
