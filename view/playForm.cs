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
    public partial class playForm : Form
    {
        public playForm()
        {
            InitializeComponent();
           
        }
        Random rd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.Show();
        }


        int count =0;
        private void timer1_auto(object sender, EventArgs e)
        {
            int valueDice1 = rd.Next(1, 6);
            int valueDice2 = rd.Next(1, 6);
            dice1.Text = valueDice1 + " ";
            dice2.Text = valueDice2 + " ";
           
            if(count >50)
            { 
                int move = valueDice1 + valueDice2;
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
