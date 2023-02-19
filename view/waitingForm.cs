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
        }
    }
}
