using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoTyPhu.control;
using CoTyPhu.control.client;


namespace CoTyPhu.view
{
    public partial class playForm : Form
    {
        
        public playForm()
        {
            InitializeComponent();
            lbNameP1.Text = main.name;
            lbRoomId.Text = main.room.ToString();
            CheckForIllegalCrossThreadCalls = false;
        }
        Random rd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.showMainForm();
        }


        int count =0;
        private void timer1_auto(object sender, EventArgs e) {
        KeyValuePair<int, int> dice = process_game.random_dice();
        dice1.Text = Convert.ToString(dice.Key);
        dice2.Text = Convert.ToString(dice.Value);
        if(count >30) {
            int move = dice.Key + dice.Value;
            labelMove.Text= move +"";
            character.Location = new Point(595, 539);
            timer1.Stop();
        }
        count++;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            timer1.Start();
        }
        int x =668, y =582, a =1;

        private void playForm_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
          
            }
            catch { }
        }
    }
}
