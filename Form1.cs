using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Back_color
{
    public partial class ChangeColor : Form
    {
        public ChangeColor()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ColorDialog dig = new ColorDialog();
            dig.ShowDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dig.Color;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
