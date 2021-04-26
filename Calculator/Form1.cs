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
            action = PrevAction.Add;
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
            if (e.KeyChar >= '0' && e.KeyChar <= '9') Digit(e.KeyChar);
            else if (e.KeyChar == '.' || e.KeyChar == ',') Point();
            else if (e.KeyChar == '=' || e.KeyChar == '\r') Equal();
            else if (e.KeyChar == '+') Add();
            else if (e.KeyChar == '-') Minus();
            else if (e.KeyChar == '/') Division();
            else if (e.KeyChar == '*') Multipl();
            else if (e.KeyChar == '\b') BackSpase();
            else if (e.KeyChar == '\u001b') Esc();
        }
        private void Esc()
        {
            equal = 0;
            tmp = 0;
            action = PrevAction.Add;
            clear = false;
            textBoxEqual.Text = "0";
            textBoxActivity.Text = "";
        }
        private void BackSpase()
        {
            if (textBoxEqual.Text.Length > 1)
                textBoxEqual.Text = textBoxEqual.Text.Remove(textBoxEqual.Text.Length - 1);
            else textBoxEqual.Text = "0";
            tmp = Convert.ToDouble(textBoxEqual.Text);
        }
        private void Digit(char sumbol)
        {
            if (action != PrevAction.Equal)
            {
                if (clear || textBoxEqual.Text == "0")
                {
                    textBoxEqual.Clear();
                    clear = false;
                }
                if (textBoxEqual.Text.Length >= 10) return;
                if (textBoxEqual.Text == "-0")
                {
                    textBoxEqual.Text = "-" + sumbol.ToString();
                }
                else
                {
                    textBoxEqual.Text += sumbol.ToString();
                }
                tmp = Convert.ToDouble(textBoxEqual.Text);
            }
        }
        private void Point()
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
        private void Add()
        {
            if (action == PrevAction.Equal) textBoxActivity.Text += " + ";
            else if (textBoxEqual.Text.Length != 0 && !clear)
            {
                textBoxActivity.Text += (textBoxEqual.Text + " + ");
                textBoxEqual.Clear();
            }
            else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " + ";
            Action();
            action = PrevAction.Add;
            clear = true;
            //tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Minus()
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
            //tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Multipl()
        {
            if (action == PrevAction.Equal) textBoxActivity.Text += " * ";
            else if (textBoxEqual.Text.Length != 0 && !clear)
            {
                textBoxActivity.Text += (textBoxEqual.Text + " * ");
                textBoxEqual.Clear();
            }
            else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " * ";
            Action();
            action = PrevAction.Multipl;
            clear = true;
            //tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Division()
        {
            if (action == PrevAction.Equal) textBoxActivity.Text += " / ";
            else if (textBoxEqual.Text.Length != 0 && !clear)
            {
                textBoxActivity.Text += (textBoxEqual.Text + " / ");
                textBoxEqual.Clear();
            }
            else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " / ";
            Action();
            action = PrevAction.Division;
            clear = true;
            //tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Equal()
        {
            if (action != PrevAction.Equal && action != PrevAction.none)
            {
                Action();
                action = PrevAction.Equal;
                textBoxActivity.Text = Convert.ToString(equal);
                textBoxEqual.Text = Convert.ToString(equal);
                tmp = Convert.ToDouble(textBoxEqual.Text);
            }
        }
    }
}
