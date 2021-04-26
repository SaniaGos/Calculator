using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum PrevAction
    {
        none, Add, Minus, Multipl, Division, Equal
    }
    public partial class Calculator : Form
    {
        private PrevAction action;
        private bool clear;
        private double equal;
        private double tmp;
        public Calculator()
        {
            InitializeComponent();
            equal = 0;
            tmp = 0;
            action = PrevAction.none;
            clear = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }
        private void Action()
        {
            switch (action)
            {
                case PrevAction.Add:
                    equal += tmp;
                    break;
                case PrevAction.Minus:
                    equal -= tmp;
                    break;
                case PrevAction.Multipl:
                    equal *= tmp;
                    break;
                case PrevAction.Division:
                    equal /= tmp;
                    break;
                default:
                    break;
            }
        }
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' && action != PrevAction.Equal)
            {
                if (clear || textBoxEqual.Text == "0")
                {
                    textBoxEqual.Clear();
                    clear = false;
                }
                if (textBoxEqual.Text.Length >= 10) return;
                if (textBoxEqual.Text == "-0")
                {
                    textBoxEqual.Text = "-" + e.KeyChar.ToString();
                }
                else
                {
                    textBoxEqual.Text += e.KeyChar.ToString();
                }
                tmp = Convert.ToDouble(textBoxEqual.Text);
            }
            else if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (textBoxEqual.Text.Length == 0)
                {
                    textBoxEqual.Text = "0,";
                }
                else
                {
                    textBoxEqual.Text += ",";
                }
                tmp = Convert.ToDouble(textBoxEqual.Text);
            }
            
            else if (e.KeyChar == '=' || e.KeyChar == '\r' &&
                action != PrevAction.Equal &&
                action != PrevAction.none)
            {
                Action();
                action = PrevAction.Equal;
                textBoxActivity.Text = Convert.ToString(equal);
                textBoxEqual.Text = Convert.ToString(equal);
            }

            else if (e.KeyChar == '+')
            {
                if (action == PrevAction.Equal) textBoxActivity.Text += " + ";
                else if (textBoxEqual.Text.Length != 0 && !clear)
                {
                    textBoxActivity.Text += (textBoxEqual.Text + " + ");
                    textBoxEqual.Clear();
                }
                else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " + ";
                if (equal == 0) equal = tmp;
                else Action();
                action = PrevAction.Add;
                clear = true;
                tmp = 0;
                textBoxEqual.Text = Convert.ToString(equal);

            }
            else if (e.KeyChar == '-')
            {
                if (action == PrevAction.Equal) textBoxActivity.Text += " + ";
                else if (textBoxEqual.Text.Length != 0 && !clear)
                {
                    textBoxActivity.Text += (textBoxEqual.Text + " - ");
                    textBoxEqual.Clear();
                }
                else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " - ";
                Action();
                action = PrevAction.Minus;
                clear = true;
                tmp = 0;
                textBoxEqual.Text = Convert.ToString(equal);
            }
        }
    }
}
