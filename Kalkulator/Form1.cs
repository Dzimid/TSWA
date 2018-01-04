﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        private Keys[] keyArray = { Keys.Back, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
        private Button[] buttonsArray;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Initialize calculator
            this.calculator = new Calculator();
            mainTextBox.Text = this.calculator.Result;

            switch (calculator.SystemV) {
                case "BIN":
                    systemBin.Checked = true;
                    break;
                case "OCT":
                    systemOct.Checked = true;
                    break;
                case "DEC":
                    systemDec.Checked = true;
                    break;
                case "HEX":
                    systemHex.Checked = true;
                    break;
            }

            Button[] btns = { buttonBackspace, button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            this.buttonsArray = btns;
    }

        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = Char.ToUpper(e.KeyChar);

            // Validation
            if (this.calculator.SystemTable[this.calculator.SystemV].Contains(keyChar)) {
                this.addToMainTextBox(keyChar);
            }

            // Backspace
            if ((char)8 == e.KeyChar) {
                this.Backspace();
            }
        }

        private string getCheckedRadioName()
        {
            foreach (Control control in this.Controls) {
                if (typeof(RadioButton) == control.GetType()) {
                    RadioButton rb = (RadioButton) control;

                    if (rb.Checked) {
                        return control.Name;
                    }
                }
            }

            return null;
        }

        public void Backspace()
        {
            if (!string.IsNullOrEmpty(mainTextBox.Text)) {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1, 1);
            }
        }

        private void addToMainTextBox(char c)
        {
            mainTextBox.Text += c;
        }

        private void systemBin_CheckedChanged(object sender, EventArgs e)
        {           
            this.calculator.SystemV = this.getCheckedRadioName().Replace("system", String.Empty).ToUpper();
        }

        private void systemOct_CheckedChanged(object sender, EventArgs e)
        {
            this.calculator.SystemV = this.getCheckedRadioName().Replace("system", String.Empty).ToUpper();
        }

        private void systemDec_CheckedChanged(object sender, EventArgs e)
        {
            this.calculator.SystemV = this.getCheckedRadioName().Replace("system", String.Empty).ToUpper();
        }

        private void systemHex_CheckedChanged(object sender, EventArgs e)
        {
            this.calculator.SystemV = this.getCheckedRadioName().Replace("system", String.Empty).ToUpper();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            this.Backspace();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var b = (Button) sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (-1 != Array.IndexOf(this.keyArray, e.KeyCode)) {
                this.buttonsArray[Array.IndexOf(this.keyArray, e.KeyCode)].BackColor = SystemColors.ControlLightLight;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (-1 != Array.IndexOf(this.keyArray, e.KeyCode)) {
                this.buttonsArray[Array.IndexOf(this.keyArray, e.KeyCode)].BackColor = SystemColors.ControlLight;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
