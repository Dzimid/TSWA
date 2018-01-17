using System;
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
        public Keys[] keyArray = { Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F };
        private Button[] buttonsArray;
        public bool isFirst = true;
        public bool isFirstOperation = true;
        public bool isOperation = false;
        public bool isMinus = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Initialize calculator
            this.calculator = new Calculator(this);
            mainTextBox.Text = this.calculator.result.ToString();

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

            Button[] btns = { buttonBackspace, button0, button1, button2, button3, button4, button5, button6, button7, button8, button9, button0, button1, button2, button3, button4, button5, button6, button7, button8, button9, buttonA, buttonB, buttonC, buttonD, buttonE, buttonF };
            this.buttonsArray = btns;
        }

        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = Char.ToUpper(e.KeyChar);
            this.addToMainTextBox(keyChar);

            // Backspace
            if ((char)8 == e.KeyChar) {
                Backspace();
            }

            // Addition
            if ((char)43 == e.KeyChar) {
                calculator.Addition();
            }

            // Substraction
            if ((char)45 == e.KeyChar) {
                calculator.Substraction();
            }

            // Multiplication
            if ((char)42 == e.KeyChar) {
                //Multiplication();
            }

            // Division
            if ((char)47 == e.KeyChar) {
                //Division();
            }

            // sum
            if ((char)61 == e.KeyChar) {
                calculator.Sum();
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
            // Validation
            if (this.calculator.SystemTable[this.calculator.SystemV].Contains(c)) {
                if (isOperation) {
                    mainTextBox.Text = c.ToString();
                } else {
                    mainTextBox.Text += c;
                }
                this.isOperation = false;
            }
        }

        //Changing number systems
        private void system_CheckedChanged(object sender, EventArgs e)
        {
            this.calculator.SystemV = this.getCheckedRadioName().Replace("system", String.Empty).ToUpper();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            this.addToMainTextBox(char.Parse(b.Text));
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            this.Backspace();
        }

        //Ligthing up keys
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (-1 != Array.IndexOf(this.keyArray, e.KeyCode)) {
                this.buttonsArray[Array.IndexOf(this.keyArray, e.KeyCode)].BackColor = SystemColors.ControlLightLight;
            }
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (-1 != Array.IndexOf(this.keyArray, e.KeyCode)) {
                this.buttonsArray[Array.IndexOf(this.keyArray, e.KeyCode)].BackColor = SystemColors.ControlLight;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calculator.Addition();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calculator.Sum();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            calculator.Substraction();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            //Multiplication();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            //Division();
        }

        private void buttonDeleteC_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "0";
            operationsTextbox.Text = "";
            isFirst = true;
            isFirstOperation = true;
            calculator.result = 0;
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isFirst && mainTextBox.Text.Length > 1) {
                mainTextBox.Text = mainTextBox.Text.ElementAt(1).ToString();
                isFirst = false;
            } 

            if (mainTextBox.Text == "0") {
                isFirst = true;
            } else {
                isFirst = false;
            }

            if(mainTextBox.Text.Length == 0) {
                mainTextBox.Text = "0";
            }
        }
    }
}
