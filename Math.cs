using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATH
{
    public partial class frmMain : Form
    {
        float num1, num2, res;                                                       // declared variable in flaot cause in case user has values in fractions.
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)                       // Calculate button
        {
            txtAns.Text = res+"";        
        }

        private void radBtn2_CheckedChanged(object sender, EventArgs e)            // radio button : Substraction
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            res = num1 - num2;
        }

        private void radBtn4_CheckedChanged(object sender, EventArgs e)           // radio button : Division
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            res = (num1 / num2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)      // radio button : Multiplication
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            res = num1 * num2;
        }

        private void radBtn1_CheckedChanged(object sender, EventArgs e)           // radio button : Addition
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            res = num1 + num2;
        }

        private void btnExit_Click(object sender, EventArgs e)                   // Exit button. Closes the consol.
        {
            this.Close();
        }
    }
}
