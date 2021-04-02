using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Ssignal
{
    public partial class Trafficsig : Form
    {
        public Trafficsig()
        {
            InitializeComponent();
            RedStop.Visible = true;
            YellowWait.Visible = false;
            Greengo.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RedStop.Visible == true)
            {
                RedStop.Visible = false;
                YellowWait.Visible = false;
                Greengo.Visible = true;
            }
            else if (Greengo.Visible == true)
            {
                RedStop.Visible = false;
                YellowWait.Visible = true;
                Greengo.Visible = false;
            }
            else if (YellowWait.Visible == true)
            {
                RedStop.Visible = true;
                YellowWait.Visible = false;
                Greengo.Visible = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
