using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_and_0
{
    public partial class mainForm : Form
    {
        public void Reset()
        {
            btn1x1.Text = "";
            btn1x2.Text = "";
            btn1x3.Text = "";
            btn2x1.Text = "";
            btn2x2.Text = "";
            btn2x3.Text = "";
            btn3x1.Text = "";
            btn3x2.Text = "";
            btn3x3.Text = "";

            btn1x1.ResetBackColor();
            btn1x2.ResetBackColor();
            btn1x3.ResetBackColor();
            btn2x1.ResetBackColor();
            btn2x2.ResetBackColor();
            btn2x3.ResetBackColor();
            btn3x1.ResetBackColor();
            btn3x2.ResetBackColor();
            btn3x3.ResetBackColor();

            btn1x1.Enabled = true;
            btn1x2.Enabled = true;
            btn1x3.Enabled = true;
            btn2x1.Enabled = true;
            btn2x2.Enabled = true;
            btn2x3.Enabled = true;
            btn3x1.Enabled = true;
            btn3x2.Enabled = true;
            btn3x3.Enabled = true;

            btn1x1.TabStop = false;
            btn1x2.TabStop = false;
            btn1x3.TabStop = false;
            btn2x1.TabStop = false;
            btn2x2.TabStop = false;
            btn2x3.TabStop = false;
            btn3x1.TabStop = false;
            btn3x2.TabStop = false;
            btn3x3.TabStop = false;

            lblRand.Text = "Randul lui X";
        }
        public void Castig()
        {
            if (btn1x1.Text == "X" && btn1x2.Text == "X" && btn1x3.Text == "X")
            {
                btn1x1.BackColor = Color.Blue;
                btn1x2.BackColor = Color.Blue;
                btn1x3.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn1x1.Text == "0" && btn1x2.Text == "0" && btn1x3.Text == "0")
            {
                btn1x1.BackColor = Color.Red;
                btn1x2.BackColor = Color.Red;
                btn1x3.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if(btn2x1.Text == "X" && btn2x2.Text == "X" && btn2x3.Text == "X")
            {
                btn2x1.BackColor = Color.Blue;
                btn2x2.BackColor = Color.Blue;
                btn2x3.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn2x1.Text == "0" && btn2x2.Text == "0" && btn2x3.Text == "0")
            {
                btn2x1.BackColor = Color.Red;
                btn2x2.BackColor = Color.Red;
                btn2x3.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if(btn3x1.Text == "X" && btn3x2.Text == "X" && btn3x3.Text == "X")
            {
                btn3x1.BackColor = Color.Blue;
                btn3x2.BackColor = Color.Blue;
                btn3x3.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn3x1.Text == "0" && btn3x2.Text == "0" && btn3x3.Text == "0")
            {
                btn3x1.BackColor = Color.Red;
                btn3x2.BackColor = Color.Red;
                btn3x3.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if(btn1x1.Text == "X" && btn2x1.Text == "X" && btn3x1.Text == "X")
            {
                btn1x1.BackColor = Color.Blue;
                btn2x1.BackColor = Color.Blue;
                btn3x1.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn1x1.Text == "0" && btn2x1.Text == "0" && btn3x1.Text == "0")
            {
                btn1x1.BackColor = Color.Red;
                btn2x1.BackColor = Color.Red;
                btn3x1.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if(btn1x2.Text == "X" && btn2x2.Text == "X" && btn3x2.Text == "X")
            {
                btn1x2.BackColor = Color.Blue;
                btn2x2.BackColor = Color.Blue;
                btn3x2.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if(btn1x2.Text == "0" && btn2x2.Text == "0" && btn3x2.Text == "0")
            {
                btn1x2.BackColor = Color.Red;
                btn2x2.BackColor = Color.Red;
                btn3x2.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }
            else if(btn1x3.Text == "X" && btn2x3.Text == "X" && btn3x3.Text == "X")
            {
                btn1x3.BackColor = Color.Blue;
                btn2x3.BackColor = Color.Blue;
                btn3x3.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn1x3.Text == "0" && btn2x3.Text == "0" && btn3x3.Text == "0")
            {
                btn1x3.BackColor = Color.Red;
                btn2x3.BackColor = Color.Red;
                btn3x3.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if(btn1x1.Text == "X" && btn2x2.Text == "X" && btn3x3.Text == "X")
            {
                btn1x1.BackColor = Color.Blue;
                btn2x2.BackColor = Color.Blue;
                btn3x3.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn1x1.Text == "0" && btn2x2.Text == "0" && btn3x3.Text == "0")
            {
                btn1x1.BackColor = Color.Red;
                btn2x2.BackColor = Color.Red;
                btn3x3.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn1x3.Text == "X" && btn2x2.Text == "X" && btn3x1.Text == "X")
            {
                btn1x3.BackColor = Color.Blue;
                btn2x2.BackColor = Color.Blue;
                btn3x1.BackColor = Color.Blue;
                MessageBox.Show("X a castigat !","X si 0",MessageBoxButtons.OK,MessageBoxIcon.Information);
                scorX++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if (btn1x3.Text == "0" && btn2x2.Text == "0" && btn3x1.Text == "0")
            {
                btn1x3.BackColor = Color.Red;
                btn2x2.BackColor = Color.Red;
                btn3x1.BackColor = Color.Red;
                MessageBox.Show("0 a castigat !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scor0++;
                lblScor.Text = "Scor " + scorX + " : " + scor0;
                Reset();
            }else if(btn1x1.Text != "" && btn1x2.Text != "" && btn1x3.Text != ""
                && btn2x1.Text != "" && btn2x2.Text != "" && btn2x3.Text != ""
                && btn3x1.Text != "" && btn3x2.Text != "" && btn3x3.Text != "")
            {
                MessageBox.Show("Remiza !", "X si 0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
        public mainForm()
        {
            InitializeComponent();
        }

        int scorX = 0, scor0 = 0;

        private void btn1x1_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn1x1.Text = "X";
                btn1x1.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }else if(lblRand.Text.Equals("Randul lui 0"))
            {
                btn1x1.Text = "0";
                btn1x1.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn1x2_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn1x2.Text = "X";
                btn1x2.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn1x2.Text = "0";
                btn1x2.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn1x3_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn1x3.Text = "X";
                btn1x3.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn1x3.Text = "0";
                btn1x3.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn2x1_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn2x1.Text = "X";
                btn2x1.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn2x1.Text = "0";
                btn2x1.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn2x2_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn2x2.Text = "X";
                btn2x2.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn2x2.Text = "0";
                btn2x2.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn2x3_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn2x3.Text = "X";
                btn2x3.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn2x3.Text = "0";
                btn2x3.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn3x1_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn3x1.Text = "X";
                btn3x1.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn3x1.Text = "0";
                btn3x1.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn3x2_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn3x2.Text = "X";
                btn3x2.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn3x2.Text = "0";
                btn3x2.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void btn3x3_Click(object sender, EventArgs e)
        {
            if (lblRand.Text.Equals("Randul lui X"))
            {
                btn3x3.Text = "X";
                btn3x3.Enabled = false;
                lblRand.Text = "Randul lui 0";
            }
            else if (lblRand.Text.Equals("Randul lui 0"))
            {
                btn3x3.Text = "0";
                btn3x3.Enabled = false;
                lblRand.Text = "Randul lui X";
            }
            Castig();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
