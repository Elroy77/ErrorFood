using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Food
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Lb_timer.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
