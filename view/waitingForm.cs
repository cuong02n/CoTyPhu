using CoTyPhu.model;
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
        public void displayLobby(lobby l) {
            lbPlayer2.Text = l.Players[1].name;
            lbPlayer3.Text = l.Players[2].name;
            lbPlayer4.Text  = l.Players[3].name;
        }
        public void create(Label a)
        {
             a.Text = main.name;
        }
        public waitingForm()
        {
            InitializeComponent();
            nameView.Text = main.name ;
            idView.Text = main.room.ToString();
            create(lbPlayer1);
            
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
