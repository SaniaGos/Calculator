using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
            FillListButtons();
            ReplaseButtons();
        }
        private void Introduction_SizeChanged(object sender, EventArgs e)
        {
            ReplaseButtons();
        }
        private void ReplaseButtons()
        {
            int x = 4;
            int y = 4;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == 0)
                {
                    buttons[i].Location = new Point(x, y);
                    x = x + 3 + buttons[i].Width;
                }
                else
                {
                    if (x + buttons[i].Width <= this.Width / 3 * 2)
                    {
                        buttons[i].Location = new Point(x, y);
                        x = x + 3 + buttons[i].Width;
                    }
                    else
                    {
                        x = 4;
                        y = y + 3 + 28;
                        buttons[i].Location = new Point(x, y);
                        x = x + 3 + buttons[i].Width;
                    }
                }
            }

        }
        private void buttonNavy_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Navy;
        }
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
        private void buttonAqua_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }
        private void buttonTeal_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Teal;
        }
        private void buttonOlive_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Olive;
        }
        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        private void buttonLime_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }
        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
        private void buttonOrange_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }
        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        private void buttonMaroon_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
        }
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        private void buttonWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        private void buttonGray_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
        private void buttonSilver_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }
        private void buttonPurple_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }
        private void buttonFuchsia_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }
    }
}
