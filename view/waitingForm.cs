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
        public waitingForm()
        {
            InitializeComponent();
            nameView.Text = mainForm.user.tbUserName + "";
            idView.Text = mainForm.user.tbRoomId + "";
        }
    }
}
