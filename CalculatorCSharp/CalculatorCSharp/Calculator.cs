/*****************************************************************
**  Program Name:   Calculator C#               				**
**  Version Number: V1.0                                        **
**  Copyright (C):  September 6, 2009 Richard W. Allen          **
**  Date Started:   September 6, 2009                           **
**  Date Ended:     September 7, 2009                           **
**  Author:         Richardn W. Allen                           **
**  Webpage:        http://richard-allen.homelinux.com/         **
**  IDE:            Visual Studio 2008                          **
**  Compiler:       C# 2008                                     **
**  Langage:        C# 2008                   				    **
**  License:        GNU GENERAL PUBLIC LICENSE Version 2    	**
**		            see license.txt for for details	            **
******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorCSharp
{
    public partial class Calculator : Form
    {
        enum Type {
            None = 0,
            Equals,
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private double cal = 0.0d;
        private Type sign = Type.None;

        private void Operator( Type type )
        {
            if (sign != Type.Equals)
            {
                if (sign == Type.None)
                    cal = double.Parse(box.Text);
                else {
                    switch (type)
                    {
                        case Type.Add:
                            cal += double.Parse(box.Text);
                            break;
                        case Type.Subtract:
                            cal -= double.Parse(box.Text);
                            break;
                        case Type.Multiply:
                            cal *= double.Parse(box.Text);
                            break;
                        case Type.Divide:
                            cal /= double.Parse(box.Text);
                            break;
                    }
                }
            }

            box.Text = string.Empty;
            sign = type;
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            box.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            box.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            box.Text += '9';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            box.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            box.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            box.Text += '6';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            box.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            box.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            box.Text += '3';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            box.Text += '0';
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Operator(Type.Add);
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            Operator(sign);
           
            box.Text = cal.ToString();
            sign = Type.Equals;
        }

        private void buttonsubtract_Click(object sender, EventArgs e)
        {
            Operator(Type.Subtract);
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            Operator(Type.Divide);
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            Operator(Type.Multiply);
        }

        private void buttonperiod_Click(object sender, EventArgs e)
        {
            if (box.Text.IndexOf('.') < 0)
                box.Text += '.';
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(box.Text);
            temp = -temp;
            box.Text = temp.ToString();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            cal = 0.0d;
            sign = Type.None;
            box.Text = string.Empty;
        }
    }
}
