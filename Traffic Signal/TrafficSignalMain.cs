using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Signal_Form
{
    public partial class TrafficSig : Form
    {
        public TrafficSig()
        {
            InitializeComponent();
            RedStop.Visible = true;
            YellowWait.Visible = false;
            GreenGo.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RedStop.Visible == true)
            {
                RedStop.Visible = false;
                YellowWait.Visible = false;
                GreenGo.Visible = true;
            }

            else if (GreenGo.Visible == true)
            {
                RedStop.Visible = false;
                YellowWait.Visible = true;
                GreenGo.Visible = false;
            }
            
            else if (YellowWait.Visible == true)
            {
                RedStop.Visible = true;
                YellowWait.Visible = false;
                GreenGo.Visible = false;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
